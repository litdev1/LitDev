//#define SVB 
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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace LitDev
{
    /// <summary>
    /// Create an icon (*.ico) or cursor (*.cur) file from an image.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDIcon
    {
        private static int[] size = { 16, 24, 32, 64, 128, 256 };
        private static bool bSquare = true;
        private static ImageFormat imageFormat = ImageFormat.Png;

        /// <summary>
        /// Scale images to keep the aspect ratio of images square (width = height), "True" (default) or "False".
        /// If set to "False" then the width of the icon or cursor will be scaled to maintain the image aspect ratio, while maintaining the set height.
        /// </summary>
        public static Primitive SquareImage
        {
            get { return bSquare; }
            set { bSquare = value; }
        }

        /// <summary>
        /// Create an icon file with 16*16, 24*24, 32*32, 64*64, 128*128 and 256*256 embedded images.
        /// To change these defaults use SetSizes method.
        /// </summary>
        /// <param name="imageName">The file path or ImageList image to create icon from.  Best results will be obtained from a square image.</param>
        /// <param name="iconPath">The full path to save the icon file (using extension *.ico).</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive CreateIcon(Primitive imageName, Primitive iconPath)
        {
            try
            {
                Type ImageListType = typeof(ImageList);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "FAILED";
                    }
                }
                Bitmap bmp = FastPixel.GetBitmap(img);
                double scaleWidth = bSquare ? 1 : (double)bmp.Width / (double)bmp.Height;

                using (FileStream outStream = new FileStream(iconPath, FileMode.Create))
                {
                    BinaryWriter bw = new BinaryWriter(outStream);
                    bw.Write((byte)0);                  // 0-1 reserved (0)
                    bw.Write((byte)0);
                    bw.Write((short)1);                 // 2-3 image type, 1=Icon, 2=Cursor	// bw.Write(icoType);
                    bw.Write((short)size.Length);                 // 4-5 number of images

                    List<byte[]> data = new List<byte[]>();
                    for (int i = 0; i < size.Length; i++)
                    {
                        Bitmap bmpIcon = new Bitmap(bmp, new Size((int)(size[i] * scaleWidth), size[i]));
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmpIcon.Save(ms, imageFormat);
                            data.Add(ms.ToArray());
                        }
                    }

                    int offset = 6 + 16 * size.Length;
                    for (int i = 0; i < size.Length; i++)
                    {
                        bw.Write((byte)(size[i] * scaleWidth));                  //	0 image width	(entry Image#1)
                        bw.Write((byte)size[i]);                  //	1 image height
                        bw.Write((byte)0);                  //	2 number of colors (0 if the image does not use a color palette)
                        bw.Write((byte)0);                  //	3 reserved (0)
                        bw.Write((short)0);                 //	4-5 color planes (Ico: 0 or 1; Cur: horiz. coord. of xHotspot, # of pxl from left)
                        bw.Write((short)32);                //	6-7 bits per pixel (Ico: bpPxl; Cur: vert. coord. of yHotspot, # of pxl from top)
                        bw.Write((int)data[i].Length);    //	8-11 size [Bytes] of image data
                        bw.Write((int)offset);                //	12-15 offset [Bytes] of Bmp/Png image data from beginning (6 + 16)
                        offset += data[i].Length;
                    }

                    for (int i = 0; i < size.Length; i++)
                    {
                        bw.Write(data[i]);      // write image data (must contain the whole png data file)
                    }

                    bw.Flush();
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Create a cursor file.
        /// </summary>
        /// <param name="imageName">The file path or ImageList image to create cursor from.  Best results will be obtained from a square image.</param>
        /// <param name="cursorPath">The full path to save the cursor file (using extension *.cur).</param>
        /// <param name="size">The pixel size of cursor.</param>
        /// <param name="xHotSpot">Pixel from left of cursor hot spot, indexed from 0.
        /// For images where the aspect ratio is maintained, the xHotSpot is also scaled.</param>
        /// <param name="yHotSpot">Pixel from top of cursor hot spot, indexed from 0.</param>
        /// <returns></returns>
        public static Primitive CreateCursor(Primitive imageName, Primitive cursorPath, Primitive size, Primitive xHotSpot, Primitive yHotSpot)
        {
            try
            {
                Type ImageListType = typeof(ImageList);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "FAILED";
                    }
                }
                Bitmap bmp = FastPixel.GetBitmap(img);
                double scaleWidth = bSquare ? 1 : (double)bmp.Width / (double)bmp.Height;

                using (FileStream outStream = new FileStream(cursorPath, FileMode.Create))
                {
                    BinaryWriter bw = new BinaryWriter(outStream);
                    bw.Write((byte)0);                  // 0-1 reserved (0)
                    bw.Write((byte)0);
                    bw.Write((short)2);                 // 2-3 image type, 1=Icon, 2=Cursor	// bw.Write(icoType);
                    bw.Write((short)1);                 // 4-5 number of images

                    Bitmap bmpIcon = new Bitmap(bmp, new Size((int)(size * scaleWidth), size));
                    byte[] data;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bmpIcon.Save(ms, imageFormat);
                        data = ms.ToArray();
                    }

                    int offset = 6 + 16;
                    bw.Write((byte)(size * scaleWidth));                  //	0 image width	(entry Image#1)
                    bw.Write((byte)size);                  //	1 image height
                    bw.Write((byte)0);                  //	2 number of colors (0 if the image does not use a color palette)
                    bw.Write((byte)0);                  //	3 reserved (0)
                    bw.Write((short)(xHotSpot * scaleWidth));                 //	4-5 color planes (Ico: 0 or 1; Cur: horiz. coord. of xHotspot, # of pxl from left)
                    bw.Write((short)yHotSpot);                //	6-7 bits per pixel (Ico: bpPxl; Cur: vert. coord. of yHotspot, # of pxl from top)
                    bw.Write((int)data.Length);    //	8-11 size [Bytes] of image data
                    bw.Write((int)offset);                //	12-15 offset [Bytes] of Bmp/Png image data from beginning (6 + 16)
                    bw.Write(data);      // write image data (must contain the whole png data file)

                    bw.Flush();
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set the default icon sizes.  This should be called before CreateIcon.
        /// </summary>
        /// <param name="sizes">A space separated list of integer icon sizes, default is "16 24 32 64 128 256".
        /// An array of integer icon sizes may also be used.
        /// The maximum size is 256.</param>
        public static void SetSizes(Primitive sizes)
        {
            sizes = sizes.ToString(); //To ensure a single value can be treated as a string
            int count = sizes.GetItemCount();
            if (count == 0)
            {
                string[] data = sizes.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                System.Array.Resize(ref size, data.Length);
                for (int i = 0; i < data.Length; i++)
                {
                    int.TryParse(data[i], out size[i]);
                }
            }
            else
            {
                Primitive indices = SBArray.GetAllIndices(sizes);
                System.Array.Resize(ref size, count);
                for (int i = 0; i < count; i++)
                {
                    size[i] = sizes[indices[i + 1]];
                }
            }
        }
    }
}
