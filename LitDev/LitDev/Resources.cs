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
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LitDev
{
    [Serializable()]
    public class Resources : ISerializable
    {
        public List<string> texts;
        public Dictionary<string, byte[]> files;
        public Dictionary<string, byte[]> images;
        public Dictionary<string, byte[]> sounds;
		
		public Resources()
		{
            texts = new List<string>();
            files = new Dictionary<string, byte[]>();
            images = new Dictionary<string, byte[]>();
            sounds = new Dictionary<string, byte[]>();
		}

        public bool AddFile(string fileName)
        {
            if (!System.IO.File.Exists(fileName)) return false;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)new FileInfo(fileName).Length;
            byte[] buffer = new byte[size];
            fs.Read(buffer, 0, size);
            fs.Close();
            files.Add(Path.GetFileName(fileName), buffer);
            return true;
        }

        public bool GetFile(string fileName)
        {
            if (!files.ContainsKey(fileName)) return false;
            FileStream fs = new FileStream(Program.Directory + "\\" + fileName, FileMode.Create);
            fs.Write(files[fileName], 0, files[fileName].Length);
            fs.Close();
            return true;
        }

        public void AddImage(string label, BitmapSource image)
        {
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                images.Add(label, ms.GetBuffer());
            }
        }

        public BitmapSource GetImage(string label)
        {
            if (!images.ContainsKey(label)) return null;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = new MemoryStream(images[label]);
            image.EndInit();
            return image;
        }

        public void AddSound(string fileName)
        {
            if (!System.IO.File.Exists(fileName)) return;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)new FileInfo(fileName).Length;
            byte[] buffer = new byte[size];
            fs.Read(buffer, 0, size);
            fs.Close();
            sounds.Add(Path.GetFileName(fileName), buffer);
        }

        public string GetSound(string label)
        {
            if (!sounds.ContainsKey(label)) return null;
            //string fileName = Program.Directory + "\\" + label;
            string fileName = Path.GetTempPath() + label;
            FileStream fs = new FileStream(fileName, FileMode.Create);
            fs.Write(sounds[label], 0, sounds[label].Length);
            fs.Close();
            return fileName;
        }

        //Deserialization constructor.
        public Resources(SerializationInfo info, StreamingContext ctxt)
		{
            texts = (List<string>)info.GetValue("Texts", typeof(List<string>));
            files = (Dictionary<string, byte[]>)info.GetValue("Files", typeof(Dictionary<string, byte[]>));
            images = (Dictionary<string, byte[]>)info.GetValue("Images", typeof(Dictionary<string, byte[]>));
            sounds = (Dictionary<string, byte[]>)info.GetValue("Sounds", typeof(Dictionary<string, byte[]>));
        }
		
		//Serialization function.
		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
            info.AddValue("Texts", texts);
            info.AddValue("Files", files);
            info.AddValue("Images", images);
            info.AddValue("Sounds", sounds);
        }
    }

    /// <summary>
    /// Save and load resources to a binary file.
    /// The resources are stored in a single file with the same name and location as the source, with extension sbres.
    /// Resources indlude all ImageList images, all sounds played with Sound.Play, as well as optionally other files or variables.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDResources
    {
        private static Resources resources = new Resources();
        private static string resourcesFile = Path.ChangeExtension(Assembly.GetEntryAssembly().Location, ".sbres");
        private static Primitive files = "";
        private static Primitive texts = "";
        private static Primitive images = "";
        private static Primitive sounds = "";

        /// <summary>
        /// Delete temporary sound files.
        /// </summary>
        public static void CleanTemp()
        {
            for (int i = 1; i <= SBArray.GetItemCount(sounds); i++)
            {
                if (System.IO.File.Exists(sounds[i]))
                {
                    Utilities.ClearMediaPlayer(sounds[i]);
                    System.IO.File.Delete(sounds[i]);
                }
            }
        }

        /// <summary>
        /// Add text, or may be variable (including arrays) to the resources to be stored.
        /// </summary>
        /// <param name="text">The text or a Small Basic variable to add to the resources.</param>
        public static void AddText(Primitive text)
        {
            resources.texts.Add(text);
        }

        /// <summary>
        /// Add any file to the resources to be stored.
        /// </summary>
        /// <param name="fileName">The full path to the file.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive AddFile(Primitive fileName)
        {
            try
            {
                return resources.AddFile(fileName) ? "SUCCESS" : "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Extract a saved file to the current directory (Program.Directory).
        /// </summary>
        /// <param name="fileName">The filename returned by Files method.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive ExtractFile(Primitive fileName)
        {
            try
            {
                return resources.GetFile(fileName) ? "SUCCESS" : "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Save all resource to the sbres file.
        /// This includes all ImageList images, pre-run sounds (Sound.Play) as well as any added files or text/variables.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Save()
        {
            try
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ImageListType = typeof(ImageList);
                Type SoundType = typeof(Sound);
                Dictionary<string, BitmapSource> _savedImages;
                Dictionary<Uri, MediaPlayer> _mediaPlayerMap;

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mediaPlayerMap = (Dictionary<Uri, MediaPlayer>)SoundType.GetField("_mediaPlayerMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                
                foreach (KeyValuePair<string, BitmapSource> kvp in _savedImages)
                {
                    resources.AddImage(kvp.Key, kvp.Value);
                }

                foreach (KeyValuePair<Uri, MediaPlayer> kvp in _mediaPlayerMap)
                {
                    resources.AddSound(kvp.Key.AbsolutePath);
                }

                Stream fs = System.IO.File.Open(resourcesFile, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(fs, resources);
                fs.Close();
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Load all previously saved resources from the sbres file.
        /// ImageList and sounds are all auto loaded ready for use.
        /// Sound files are re-created in your %temp% folder since they are required by Sound.Play.
        /// </summary>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Load()
        {
            try
            {
                if (!System.IO.File.Exists(resourcesFile)) return "FAILED";
                Stream fs = System.IO.File.Open(resourcesFile, FileMode.Open, FileAccess.Read);
                BinaryFormatter bformatter = new BinaryFormatter();
                resources = (Resources)bformatter.Deserialize(fs);
                fs.Close();

                Type GraphicsWindowType = typeof(GraphicsWindow);
                Type ShapesType = typeof(Shapes);
                Type ImageListType = typeof(ImageList);
                Type SoundType = typeof(Sound);
                Dictionary<string, BitmapSource> _savedImages;
                Dictionary<Uri, MediaPlayer> _mediaPlayerMap;
                int i;

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mediaPlayerMap = (Dictionary<Uri, MediaPlayer>)SoundType.GetField("_mediaPlayerMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                texts = "";
                i = 1;
                foreach (string text in resources.texts)
                {
                    texts[i++] = text;
                }

                files = "";
                i = 1;
                foreach (KeyValuePair<string, byte[]> kvp in resources.files)
                {
                    files[i++] = kvp.Key;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        images = "";
                        i = 1;
                        foreach (KeyValuePair<string, byte[]> kvp in resources.images)
                        {
                            BitmapSource bitmapSource = resources.GetImage(kvp.Key);
                            if (null != bitmapSource)
                            {
                                _savedImages[kvp.Key] = bitmapSource;
                                images[i++] = kvp.Key;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);

                sounds = "";
                i = 1;
                foreach (KeyValuePair<string, byte[]> kvp in resources.sounds)
                {
                    string fileName = resources.GetSound(kvp.Key);
                    if (null != fileName)
                    {
                        Uri uri = new Uri(fileName);
                        MediaPlayer mediaPlayer = new MediaPlayer();
                        mediaPlayer.Open(uri);
                        _mediaPlayerMap[uri] = mediaPlayer;
                        sounds[i++] = fileName;
                    }
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
        /// Get an array list of all loaded text/variables.
        /// </summary>
        public static Primitive Texts
        {
            get { return texts; }
        }

        /// <summary>
        /// Get an array of loaded files, that may be extracted with ExtractFile method.
        /// </summary>
        public static Primitive Files
        {
            get { return files; }
        }

        /// <summary>
        /// Get an array of loaded images, pre-loaded for use with ImageList.
        /// </summary>
        public static Primitive Images
        {
            get { return images; }
        }

        /// <summary>
        /// Get an array of loaded sounds, pre-loaded for use with Sound.Play.
        /// </summary>
        public static Primitive Sounds
        {
            get { return sounds; }
        }
    }
}
