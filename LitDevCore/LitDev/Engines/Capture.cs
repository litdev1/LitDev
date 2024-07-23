﻿/****************************************************************************
While the underlying libraries are covered by LGPL, this sample is released 
as public domain.  It is distributed in the hope that it will be useful, but 
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
or FITNESS FOR A PARTICULAR PURPOSE.  
*****************************************************************************/

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

using DirectShowLib;


namespace LitDev.Engines
{
    /// <summary> Summary description for MainForm. </summary>
    public class Capture : ISampleGrabberCB, IDisposable
    {
        #region Member variables

        /// <summary> graph builder interface. </summary>
        private IFilterGraph2 m_FilterGraph = null;
        private IMediaControl m_mediaCtrl = null;

        /// <summary> so we can wait for the async job to finish </summary>
        private ManualResetEvent m_PictureReady = null;

        /// <summary> Set by async routine when it captures an image </summary>
        private volatile bool m_bGotOne = false;

        /// <summary> Indicates the status of the graph </summary>
        private bool m_bRunning = false;

        /// <summary> Dimensions of the image, calculated once in constructor. </summary>
        private IntPtr m_handle = IntPtr.Zero;
        private int m_videoWidth;
        private int m_videoHeight;
        private int m_stride;
        public int m_Dropped = 0;

        #endregion

        #region API

        [DllImport("Kernel32.dll", EntryPoint="RtlMoveMemory")]
        private static extern void CopyMemory(IntPtr Destination, IntPtr Source, int Length);

        #endregion

        public bool IsRunning { get { return m_bRunning; } }

        /// <summary> Use capture device zero, default frame rate and size</summary>
        public Capture()
        {
            _Capture(0, 0, 0, 0);
        }
        /// <summary> Use specified capture device, default frame rate and size</summary>
        public Capture(int iDeviceNum)
        {
            _Capture(iDeviceNum, 0, 0, 0);
        }
        /// <summary> Use specified capture device, specified frame rate and default size</summary>
        public Capture(int iDeviceNum, int iFrameRate)
        {
            _Capture(iDeviceNum, iFrameRate, 0, 0);
        }
        /// <summary> Use specified capture device, specified frame rate and size</summary>
        public Capture(int iDeviceNum, int iFrameRate, int iWidth, int iHeight)
        {
            _Capture(iDeviceNum, iFrameRate, iWidth, iHeight);
        }
        /// <summary> release everything. </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                CloseInterfaces();
                if (m_PictureReady != null)
                {
                    m_PictureReady.Close();
                    m_PictureReady = null;
                }
            }
            // free native resources if there are any.
        }
        // Destructor
        ~Capture()
        {
            Dispose(false);
        }

        public int Width
        {
            get
            {
                return m_videoWidth;
            }
        }
        public int Height
        {
            get
            {
                return m_videoHeight;
            }
        }
        public int Stride
        {
            get
            {
                return m_stride;
            }
        }
        /// <summary> capture the next image </summary>
        public IntPtr GetBitMap()
        {
            if (IntPtr.Zero == m_handle) m_handle = Marshal.AllocCoTaskMem(m_stride * m_videoHeight);

            try
            {
                // get ready to wait for new image
                m_PictureReady.Reset();
                m_bGotOne = false;

                // If the graph hasn't been started, start it.
                Start();

                // Start waiting
                if ( ! m_PictureReady.WaitOne(5000, false) )
                {
                    //throw new Exception("Timeout waiting to get picture");
                }
            }
            catch
            {
                Marshal.FreeCoTaskMem(m_handle);
                throw;
            }
	
            // Got one
            return m_handle;
        }
        // Start the capture graph
        public void Start()
        {
            if (!m_bRunning)
            {
                int hr = m_mediaCtrl.Run();
                DsError.ThrowExceptionForHR( hr );

                m_bRunning = true;
            }
        }
        // Pause the capture graph.
        // Running the graph takes up a lot of resources.  Pause it when it
        // isn't needed.
        public void Pause()
        {
            if (m_bRunning)
            {
                int hr = m_mediaCtrl.Pause();
                DsError.ThrowExceptionForHR( hr );

                m_bRunning = false;
            }
        }


        // Internal capture
        private void _Capture(int iDeviceNum, int iFrameRate, int iWidth, int iHeight)
        {
            DsDevice[] capDevices;

            // Get the collection of video devices
            capDevices = DsDevice.GetDevicesOfCat( FilterCategory.VideoInputDevice );

            if (iDeviceNum + 1 > capDevices.Length)
            {
                throw new Exception("No video capture devices found at that index!");
            }

            try
            {
                // Set up the capture graph
                SetupGraph( capDevices[iDeviceNum], iFrameRate, iWidth, iHeight);

                // tell the callback to ignore new images
                m_PictureReady = new ManualResetEvent(false);
                m_bGotOne = true;
                m_bRunning = false;
            }
            catch
            {
                Dispose();
                throw;
            }
        }

        /// <summary> build the capture graph for grabber. </summary>
        private void SetupGraph(DsDevice dev, int iFrameRate, int iWidth, int iHeight)
        {
            int hr;

            ISampleGrabber sampGrabber = null;
            IBaseFilter capFilter = null;
            ICaptureGraphBuilder2 capGraph = null;

            // Get the graphbuilder object
            m_FilterGraph = (IFilterGraph2) new FilterGraph();
            m_mediaCtrl = m_FilterGraph as IMediaControl;
            try
            {
                // Get the ICaptureGraphBuilder2
                capGraph = (ICaptureGraphBuilder2) new CaptureGraphBuilder2();

                // Get the SampleGrabber interface
                sampGrabber = (ISampleGrabber) new SampleGrabber();

                // Start building the graph
                hr = capGraph.SetFiltergraph( m_FilterGraph );
                DsError.ThrowExceptionForHR( hr );

                // Add the video device
                hr = m_FilterGraph.AddSourceFilterForMoniker(dev.Mon, null, "Video input", out capFilter);
                DsError.ThrowExceptionForHR( hr );

                IBaseFilter baseGrabFlt = (IBaseFilter)	sampGrabber;
                ConfigureSampleGrabber(sampGrabber);

                // Add the frame grabber to the graph
                hr = m_FilterGraph.AddFilter( baseGrabFlt, "Ds.NET Grabber" );
                DsError.ThrowExceptionForHR( hr );

                // If any of the default config items are set
                if (iFrameRate + iHeight + iWidth > 0)
                {
                    SetConfigParms(capGraph, capFilter, iFrameRate, iWidth, iHeight);
                }

                hr = capGraph.RenderStream( PinCategory.Capture, MediaType.Video, capFilter, null, baseGrabFlt );
                DsError.ThrowExceptionForHR( hr );

                SaveSizeInfo(sampGrabber);
            }
            finally
            {
                if (capFilter != null)
                {
                    Marshal.ReleaseComObject(capFilter);
                    capFilter = null;
                }
                if (sampGrabber != null)
                {
                    Marshal.ReleaseComObject(sampGrabber);
                    sampGrabber = null;
                }
                if (capGraph != null)
                {
                    Marshal.ReleaseComObject(capGraph);
                    capGraph = null;
                }
            }
        }

        private void SaveSizeInfo(ISampleGrabber sampGrabber)
        {
            int hr;

            // Get the media type from the SampleGrabber
            AMMediaType media = new AMMediaType();
            hr = sampGrabber.GetConnectedMediaType( media );
            DsError.ThrowExceptionForHR( hr );

            if( (media.formatType != FormatType.VideoInfo) || (media.formatPtr == IntPtr.Zero) )
            {
                throw new NotSupportedException( "Unknown Grabber Media Format" );
            }

            // Grab the size info
            VideoInfoHeader videoInfoHeader = (VideoInfoHeader) Marshal.PtrToStructure( media.formatPtr, typeof(VideoInfoHeader) );
            m_videoWidth = videoInfoHeader.BmiHeader.Width;
            m_videoHeight = videoInfoHeader.BmiHeader.Height;
            m_stride = m_videoWidth * (videoInfoHeader.BmiHeader.BitCount / 8);

            DsUtils.FreeAMMediaType(media);
            media = null;
        }
        private void ConfigureSampleGrabber(ISampleGrabber sampGrabber)
        {
            AMMediaType media;
            int hr;

            // Set the media type to Video/RBG24
            media = new AMMediaType();
            media.majorType	= MediaType.Video;
            media.subType	= MediaSubType.RGB24;
            media.formatType = FormatType.VideoInfo;
            hr = sampGrabber.SetMediaType( media );
            DsError.ThrowExceptionForHR( hr );

            DsUtils.FreeAMMediaType(media);
            media = null;

            // Configure the samplegrabber
            hr = sampGrabber.SetCallback( this, 1 );
            DsError.ThrowExceptionForHR( hr );
        }

        // Set the Framerate, and video size
        private void SetConfigParms(ICaptureGraphBuilder2 capGraph, IBaseFilter capFilter, int iFrameRate, int iWidth, int iHeight)
        {
            int hr;
            object o;
            AMMediaType media;

            // Find the stream config interface
            hr = capGraph.FindInterface(
                PinCategory.Capture, MediaType.Video, capFilter, typeof(IAMStreamConfig).GUID, out o );

            IAMStreamConfig videoStreamConfig = o as IAMStreamConfig;
            if (videoStreamConfig == null)
            {
                throw new Exception("Failed to get IAMStreamConfig");
            }

            // Get the existing format block
            hr = videoStreamConfig.GetFormat( out media);
            DsError.ThrowExceptionForHR( hr );

            // copy out the videoinfoheader
            VideoInfoHeader v = new VideoInfoHeader();
            Marshal.PtrToStructure( media.formatPtr, v );

            // if overriding the framerate, set the frame rate
            if (iFrameRate > 0)
            {
                v.AvgTimePerFrame = 10000000 / iFrameRate;
            }

            // if overriding the width, set the width
            if (iWidth > 0)
            {
                v.BmiHeader.Width = iWidth;
            }

            // if overriding the Height, set the Height
            if (iHeight > 0)
            {
                v.BmiHeader.Height = iHeight;
            }

            // Copy the media structure back
            Marshal.StructureToPtr( v, media.formatPtr, false );

            // Set the new format
            hr = videoStreamConfig.SetFormat( media );
            DsError.ThrowExceptionForHR( hr );

            DsUtils.FreeAMMediaType(media);
            media = null;
        }

        /// <summary> Shut down capture </summary>
        private void CloseInterfaces()
        {
            int hr;

            try
            {
                if( m_mediaCtrl != null )
                {
                    // Stop the graph
                    hr = m_mediaCtrl.Stop();
                    m_bRunning = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            if (m_FilterGraph != null)
            {
                Marshal.ReleaseComObject(m_FilterGraph);
                m_FilterGraph = null;
            }
        }

        /// <summary> sample callback, NOT USED. </summary>
        int ISampleGrabberCB.SampleCB( double SampleTime, IMediaSample pSample )
        {
            if (!m_bGotOne)
            {
                // Set bGotOne to prevent further calls until we
                // request a new bitmap.
                m_bGotOne = true;
                IntPtr pBuffer;

                pSample.GetPointer(out pBuffer);
                int iBufferLen = pSample.GetSize();

                if (pSample.GetSize() > m_stride * m_videoHeight)
                {
                    throw new Exception("Buffer is wrong size");
                }

                CopyMemory(m_handle, pBuffer, m_stride * m_videoHeight);

                // Picture is ready.
                m_PictureReady.Set();
            }

            Marshal.ReleaseComObject(pSample);
            return 0;
        }

        /// <summary> buffer callback, COULD BE FROM FOREIGN THREAD. </summary>
        int ISampleGrabberCB.BufferCB( double SampleTime, IntPtr pBuffer, int BufferLen )
        {
            if (!m_bGotOne)
            {
                // The buffer should be long enought
                if(BufferLen <= m_stride * m_videoHeight)
                {
                    // Copy the frame to the buffer
                    CopyMemory(m_handle, pBuffer, m_stride * m_videoHeight);
                }
                else
                {
                    throw new Exception("Buffer is wrong size");
                }

                // Set bGotOne to prevent further calls until we
                // request a new bitmap.
                m_bGotOne = true;

                // Picture is ready.
                m_PictureReady.Set();
            }
            else
            {
                m_Dropped++;
            }
            return 0;
        }
    }
}
