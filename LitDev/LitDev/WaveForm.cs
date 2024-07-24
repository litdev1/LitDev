﻿//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using SlimDX.DirectSound;
using SlimDX.Multimedia;
using System.Threading;
using LitDev.Engines;

//Based on https://www.insecure.ws/2010/03/09/control-rc-aircrafts-from-your-computer-for-0

namespace LitDev
{
    class Buffer
    {
        public SecondarySoundBuffer secondarySoundBuffer;
        public double duration;
        public double frequency;
        public bool bPlaying;
        public bool bDispose;
        public bool bLoop;
        public string name;

        public Buffer(string name, SecondarySoundBuffer secondarySoundBuffer, double frequency, double duration, bool bDispose = true)
        {
            this.name = name;
            this.secondarySoundBuffer = secondarySoundBuffer;
            this.frequency = frequency;
            this.duration = duration;
            this.bDispose = bDispose;
            bPlaying = true;
            bLoop = LDWaveForm.bLoop;
        }
    }

    /// <summary>
    /// Create PPM (Pulse Position Modulation) sound signals to control RC (remote control) devices.
    /// See http://blogs.msdn.com/b/smallbasic/archive/2014/05/10/smallbasic-pulse-position-modulation-extension.aspx.
    /// Additonally create simple sound waveforms, which can be played asynchronously at the same time.
    /// 
    /// SlimDX runtme for .Net 4.0 requires to be installed before this object can be used (http://slimdx.org/download.php).
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDWaveForm
    {
        static LDWaveForm()
        {
            Instance.Verify();
        }

        private static DirectSound directSound = null;
        private static WaveFormat waveFormat;
        private static short amplitude = 20262;
        private static bool bAsync = false;
        private static int index = 0;
        private static int pan = 0;
        private static int volume = 0;
        private static List<Buffer> buffers = new List<Buffer>();

        public static bool bLoop = false;

        private static void DoPlay(Object obj)
        {
            Buffer buffer = (Buffer)obj;
            double duration = buffer.duration;

            if (duration < -1 && buffer.frequency > 0)
            {
                double playtime = 1000 / buffer.frequency;
                if (playtime < 100) duration *= -playtime;
            }

            if (duration > 0)
            {
                //play audio buffer			
                buffer.secondarySoundBuffer.Play(0, PlayFlags.Looping);

                //wait to complete before returning
                DateTime start = DateTime.Now;
                while (buffer.bPlaying && (buffer.secondarySoundBuffer.Status & BufferStatus.Playing) != 0)
                {
                    if (!buffer.bLoop && (DateTime.Now - start).TotalMilliseconds > duration) break;
                }
            }
            else
            {
                for (int i = 0; i < -duration; i++)
                {
                    //play audio buffer			
                    buffer.secondarySoundBuffer.Play(0, PlayFlags.None);

                    //wait to complete before returning
                    while (buffer.bPlaying && (buffer.secondarySoundBuffer.Status & BufferStatus.Playing) != 0)
                    {
                    }
                    if (!buffer.bPlaying) break;
                }
            }

            if (buffer.bDispose)
            {
                buffer.secondarySoundBuffer.Dispose();
                buffers.Remove(buffer);
            }
        }

        private static void Initialise()
        {
            try
            {
                if (directSound == null)
                {
                    //Initialize the DirectSound Device
                    directSound = new DirectSound();

                    waveFormat = new WaveFormat();
                    waveFormat.BitsPerSample = 16;
                    waveFormat.Channels = 1;
                    waveFormat.BlockAlignment = (short)(waveFormat.BitsPerSample / 8);

                    waveFormat.FormatTag = WaveFormatTag.Pcm;
                    waveFormat.SamplesPerSecond = 192000;
                    waveFormat.AverageBytesPerSecond = waveFormat.SamplesPerSecond * waveFormat.BlockAlignment;
                }
                // Set the priority of the device with the rest of the operating system
                directSound.SetCooperativeLevel(User32.GetForegroundWindow(), CooperativeLevel.Priority);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static string NextName()
        {
            return "WaveForm" + (index++).ToString();
        }

        private static string _Play(double frequency, double duration, int iType)
        {
            try
            {
                Initialise();
                int sampleCount = (int)(waveFormat.SamplesPerSecond / frequency);

                // buffer description         
                SoundBufferDescription soundBufferDescription = new SoundBufferDescription();
                soundBufferDescription.Format = waveFormat;
                soundBufferDescription.Flags = BufferFlags.Defer | BufferFlags.ControlVolume | BufferFlags.ControlPan;
                soundBufferDescription.SizeInBytes = sampleCount * waveFormat.BlockAlignment;

                SecondarySoundBuffer secondarySoundBuffer = new SecondarySoundBuffer(directSound, soundBufferDescription);
                secondarySoundBuffer.Pan = pan;
                secondarySoundBuffer.Volume = volume;

                short[] rawsamples = new short[sampleCount];
                double frac, value;

                switch (iType)
                {
                    case 1: //Sinusoidal
                        for (int i = 0; i < sampleCount; i++)
                        {
                            frac = i / (double)sampleCount;
                            value = System.Math.Sin(2.0 * System.Math.PI * frac);
                            rawsamples[i] = (short)(amplitude * value);
                        }
                        break;
                    case 2: //Square
                        for (int i = 0; i < sampleCount; i++)
                        {
                            frac = i / (double)sampleCount;
                            frac = frac - (int)frac;
                            value = frac < 0.5 ? -1.0 : 1.0;
                            rawsamples[i] = (short)(amplitude * value);
                        }
                        break;
                }
                secondarySoundBuffer.Write(rawsamples, 0, LockFlags.EntireBuffer);

                string name = NextName();
                Buffer buffer = new Buffer(name, secondarySoundBuffer, frequency, duration);
                buffers.Add(buffer);

                Thread thread = new Thread(new ParameterizedThreadStart(DoPlay));
                thread.Start(buffer);
                if (!bAsync) thread.Join();
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        private static string _PlayDX7(Primitive channels)
        {
            try
            {
                Initialise();
                int i, iServo;
                double duration = 0.0225;
                int sampleCount = (int)(duration * waveFormat.SamplesPerSecond);

                // buffer description         
                SoundBufferDescription soundBufferDescription = new SoundBufferDescription();
                soundBufferDescription.Format = waveFormat;
                soundBufferDescription.Flags = BufferFlags.Defer | BufferFlags.ControlVolume | BufferFlags.ControlPan;
                soundBufferDescription.SizeInBytes = sampleCount * waveFormat.BlockAlignment;

                SecondarySoundBuffer secondarySoundBuffer = new SecondarySoundBuffer(directSound, soundBufferDescription);
                secondarySoundBuffer.Pan = pan;
                secondarySoundBuffer.Volume = volume;

                short[] rawsamples = new short[sampleCount];
                int stopSamples = (int)(0.0004 * waveFormat.SamplesPerSecond);
                List<int> servoSamples = new List<int>();
                Primitive indices = SBArray.GetAllIndices(channels);
                int servoCount = SBArray.GetItemCount(indices);
                for (iServo = 1; iServo <= servoCount; iServo++)
                {
                    servoSamples.Add((int)((0.0007 + 0.0008 * channels[indices[iServo]]) * waveFormat.SamplesPerSecond));
                }
                //Lead-in
                int leading = sampleCount - (servoCount + 1) * stopSamples - servoSamples.Sum();
                int sample = 0;
                for (i = 0; i < leading; i++) rawsamples[sample++] = 0;
                //Servos
                for (i = 0; i < stopSamples; i++) rawsamples[sample++] = (short)(-amplitude);
                for (iServo = 0; iServo < servoCount; iServo++)
                {
                    for (i = 0; i < servoSamples[iServo]; i++) rawsamples[sample++] = amplitude;
                    for (i = 0; i < stopSamples; i++) rawsamples[sample++] = (short)(-amplitude);
                }
                secondarySoundBuffer.Write(rawsamples, 0, LockFlags.EntireBuffer);

                string name = NextName();
                Buffer buffer = new Buffer(name, secondarySoundBuffer, 0, -1);
                buffers.Add(buffer);

                Thread thread = new Thread(new ParameterizedThreadStart(DoPlay));
                thread.Start(buffer);
                if (!bAsync) thread.Join();
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        private static string _PlayWave(double frequency, double duration, Primitive waveform)
        {
            try
            {
                Initialise();
                int sampleCount = (int)(waveFormat.SamplesPerSecond / frequency);

                // buffer description         
                SoundBufferDescription soundBufferDescription = new SoundBufferDescription();
                soundBufferDescription.Format = waveFormat;
                soundBufferDescription.Flags = BufferFlags.Defer | BufferFlags.ControlVolume | BufferFlags.ControlPan;
                soundBufferDescription.SizeInBytes = sampleCount * waveFormat.BlockAlignment;

                SecondarySoundBuffer secondarySoundBuffer = new SecondarySoundBuffer(directSound, soundBufferDescription);
                secondarySoundBuffer.Pan = pan;
                secondarySoundBuffer.Volume = volume;

                short[] rawsamples = new short[sampleCount];
                double frac, value;

                Primitive indices = SBArray.GetAllIndices(waveform);
                int count = SBArray.GetItemCount(waveform);
                double interval = indices[count] - indices[1];
                double[] timeFrac = new double[count];
                double[] timeValue = new double[count];
                for (int i = 1; i <= count; i++) //Normalise to interval 1;
                {
                    timeFrac[i - 1] = (indices[i] - indices[1]) / interval;
                    timeValue[i - 1] = waveform[indices[i]];
                }

                for (int i = 0; i < sampleCount; i++)
                {
                    frac = i / (double)sampleCount;
                    frac = frac - (int)frac;
                    for (int j = 0; j < count - 1; j++)
                    {
                        if (frac >= timeFrac[j] && frac <= timeFrac[j + 1])
                        {
                            value = timeValue[j] + (timeValue[j + 1] - timeValue[j]) * (frac - timeFrac[j]) / (timeFrac[j + 1] - timeFrac[j]);
                            rawsamples[i] = (short)(amplitude * value);
                            break;
                        }
                    }
                }
                secondarySoundBuffer.Write(rawsamples, 0, LockFlags.EntireBuffer);

                string name = NextName();
                Buffer buffer = new Buffer(name, secondarySoundBuffer, frequency, duration);
                buffers.Add(buffer);

                Thread thread = new Thread(new ParameterizedThreadStart(DoPlay));
                thread.Start(buffer);
                if (!bAsync) thread.Join();
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        private static string _PlayHarmonics(double frequency, double duration, Primitive harmonics)
        {
            try
            {
                Initialise();
                int sampleCount = (int)(waveFormat.SamplesPerSecond / frequency);

                // buffer description         
                SoundBufferDescription soundBufferDescription = new SoundBufferDescription();
                soundBufferDescription.Format = waveFormat;
                soundBufferDescription.Flags = BufferFlags.Defer | BufferFlags.ControlVolume | BufferFlags.ControlPan;
                soundBufferDescription.SizeInBytes = sampleCount * waveFormat.BlockAlignment;

                SecondarySoundBuffer secondarySoundBuffer = new SecondarySoundBuffer(directSound, soundBufferDescription);
                secondarySoundBuffer.Pan = pan;
                secondarySoundBuffer.Volume = volume;

                short[] rawsamples = new short[sampleCount];
                double frac, value;

                Primitive indices = SBArray.GetAllIndices(harmonics);
                int count = SBArray.GetItemCount(harmonics);

                for (int i = 0; i < sampleCount; i++)
                {
                    frac = i / (double)sampleCount;
                    value = System.Math.Sin(2.0 * System.Math.PI * frac);
                    for (int j = 1; j <= count; j++)
                    {
                        double harmonic = indices[j];
                        value += harmonics[harmonic] * System.Math.Sin(2.0 * System.Math.PI * harmonic * frac);
                    }
                    rawsamples[i] = (short)(amplitude * value);
                }
                secondarySoundBuffer.Write(rawsamples, 0, LockFlags.EntireBuffer);

                string name = NextName();
                Buffer buffer = new Buffer(name, secondarySoundBuffer, frequency, duration);
                buffers.Add(buffer);

                Thread thread = new Thread(new ParameterizedThreadStart(DoPlay));
                thread.Start(buffer);
                if (!bAsync) thread.Join();
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        private static string _PlayWavFile(string fileName, double duration)
        {
            try
            {
                Initialise();

                WaveStream waveFile = new WaveStream(fileName);
                SoundBufferDescription soundBufferDescription = new SoundBufferDescription();
                soundBufferDescription.Format = waveFile.Format;
                soundBufferDescription.Flags = BufferFlags.Defer | BufferFlags.ControlVolume | BufferFlags.ControlPan;
                soundBufferDescription.SizeInBytes = (int)waveFile.Length;

                SecondarySoundBuffer secondarySoundBuffer = new SecondarySoundBuffer(directSound, soundBufferDescription);
                secondarySoundBuffer.Pan = pan;
                secondarySoundBuffer.Volume = volume;

                byte[] rawsamples = new byte[soundBufferDescription.SizeInBytes];
                waveFile.Read(rawsamples, 0, soundBufferDescription.SizeInBytes);
                waveFile.Close();
                secondarySoundBuffer.Write(rawsamples, 0, LockFlags.EntireBuffer);

                string name = NextName();
                Buffer buffer = new Buffer(name, secondarySoundBuffer, 0, duration);
                buffers.Add(buffer);

                Thread thread = new Thread(new ParameterizedThreadStart(DoPlay));
                thread.Start(buffer);
                if (!bAsync) thread.Join();
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
        
        /// <summary>
        /// The volume to play the waveform (0 to 100).
        /// </summary>
        public static Primitive Volume
        {
            get { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return ""; return 100 + (volume / 100.0); }
            set { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return; volume = 100 * (System.Math.Min(100, System.Math.Max(0, value)) - 100); }
        }

        /// <summary>
        /// The left (-100) to right (100) stereo panning, (default 0).
        /// </summary>
        public static Primitive Pan
        {
            get { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return ""; return pan / 100.0; }
            set { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return; pan = 100 * System.Math.Min(100, System.Math.Max(0, value)); }
        }

        /// <summary>
        /// Continuously loop the sound, "True" or "False" default.
        /// Lopping sounds can be stopped by calling Stop method as they are playing.
        /// </summary>
        public static Primitive Loop
        {
            get { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return ""; return bLoop; }
            set { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return; bLoop = value; }
        }

        /// <summary>
        /// Stop a playing sound.
        /// </summary>
        /// <param name="waveName">The sound wave name.</param>
        public static void Stop(Primitive waveName)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return;

            foreach (Buffer buffer in buffers)
            {
                if (waveName == buffer.name) buffer.bPlaying = false;
            }
        }

        /// <summary>
        /// Play the sound asynchronously (return before sound completes), "True" or "False" default.
        /// </summary>
        public static Primitive Async
        {
            get { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return ""; return bAsync; }
            set { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return; bAsync = value; }
        }

        /// <summary>
        /// Signal amplitude (maximum is 2^15 = 32768, default is 20262).
        /// </summary>
        public static Primitive Amplitude
        {
            get { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return ""; return (int)amplitude; }
            set { if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return; amplitude = (short)value; }
        }

        /// <summary>
        /// Play a Sine wave form.
        /// </summary>
        /// <param name="frequency">Frequency (HZ).</param>
        /// <param name="duration">Duration (ms).  If this is negative then the waveform is repeated (-duration) times.</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlaySineWave(Primitive frequency, Primitive duration)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _Play(frequency, duration, 1);
        }

        /// <summary>
        /// Play a square wave form.
        /// </summary>
        /// <param name="frequency">Frequency (HZ).</param>
        /// <param name="duration">Duration (ms).  If this is negative then the waveform is repeated (-duration) times.</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlaySquareWave(Primitive frequency, Primitive duration)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _Play(frequency, duration, 2);
        }

        /// <summary>
        /// Play a user defined wave form.
        /// </summary>
        /// <param name="frequency">Frequency (HZ).</param>
        /// <param name="duration">Duration (ms).  If this is negative then the waveform is repeated (-duration) times.</param>
        /// <param name="waveform">Form for the repeating wave.
        /// This is an array, where the index is an increasing relative time (the actual value is normalised to the frequency) and the value is an amplitude (-1 to 1).
        /// Example of a triangular wave would be "0=-1;1=1;2=-1;"</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlayWave(Primitive frequency, Primitive duration, Primitive waveform)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _PlayWave(frequency, duration, waveform);
        }

        /// <summary>
        /// Play a user defined wave form as a sum of harmonics.
        /// </summary>
        /// <param name="frequency">Frequency (HZ).</param>
        /// <param name="duration">Duration (ms).  If this is negative then the waveform is repeated (-duration) times.</param>
        /// <param name="harmonics">Harmonic amplitudes.
        /// This is an array, where the index is a harmonic multiple of the base frequency (2, 3, etc) and the value is the relative amplitude of the harmonic.
        /// A square wave can be formed by (https://en.wikipedia.org/wiki/Square_wave):
        /// For i = 3 To 21 Step 2
        ///   harmonics[i] = 1/i
        /// EndFor
        /// squareWave = LDWaveForm.PlayHarmonics(256,1000,harmonics)</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlayHarmonics(Primitive frequency, Primitive duration, Primitive harmonics)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _PlayHarmonics(frequency, duration, harmonics);
        }

        /// <summary>
        /// Play a wav file.
        /// </summary>
        /// <param name="fileName">The *.wav file.</param>
        /// <param name="duration">Duration (ms).  If this is negative then the waveform is repeated (-duration) times.</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlayWavFile(Primitive fileName, Primitive duration)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _PlayWavFile(fileName, duration);
        }

        /// <summary>
        /// Play DX7.
        /// </summary>
        /// <param name="channels">An array of values for each channel (values between 0 and 1, usually 8 channels).</param>
        /// <returns>The wave name or "" on failure.</returns>
        public static Primitive PlayDX7(Primitive channels)
        {
            if (!VerifySlimDX.Verify(Utilities.GetCurrentMethod())) return "";
            return _PlayDX7(channels);
        }
    }
}
