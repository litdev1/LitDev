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

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace LitDev
{
    /// <summary>
    /// The Settings library consists of helpers that allow programs to
    /// store and retrieve user settings.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDSettings
    {
        private static Primitive _filePath = new Primitive();

        private static Dictionary<string, string> ReadContents(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
            return (Dictionary<string, string>)formatter.Deserialize(stream);
        }

        private static void WriteContents(Stream stream, Dictionary<string, string> map)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
            formatter.Serialize(stream, map);
        }
        
        /// <summary>
        /// Gets or sets the file path for the settings file.
        /// </summary>
        public static Primitive FilePath
        {
            get
            {
                if (string.IsNullOrEmpty(_filePath))
                {
                    _filePath = Path.ChangeExtension(Assembly.GetEntryAssembly().Location, ".settings");
                }

                return _filePath;
            }
            set
            {
                _filePath = value;
            }
        }
 
        /// <summary>
        /// Gets the value for the setting identified by the specified name.
        /// </summary>
        /// <param name="name">
        /// The Name of the setting.
        /// </param>
        /// <returns>
        /// The Value of the setting.
        /// </returns>
        public static Primitive GetValue(Primitive name)
        {
            if (System.IO.File.Exists(FilePath))
            {
                using (Stream stream = System.IO.File.Open(FilePath,FileMode.Open))
                {
                    Dictionary<string, string> contents = ReadContents(stream);
                    if (contents.ContainsKey  (name)) { return contents[name]; }
                }
            }
 
            return "";
        }
 
        /// <summary>
        /// Sets a value for a setting identified by the specified name.
        /// </summary>
        /// <param name="name">
        /// The Name of the setting.
        /// </param>
        /// <param name="value">
        /// The Value of the setting.
        /// </param>
        public static void SetValue(Primitive name, Primitive value)
        {
            Dictionary<string, string> contents = null;
            if (System.IO.File.Exists(FilePath))
            {
                using (Stream stream = System.IO.File.Open(FilePath, FileMode.Open))
                {
                    contents = ReadContents(stream);
                }
            }
            else
            {
                contents = new Dictionary<string, string>();
            }
 
            contents[name] = value;
            using (Stream stream = System.IO.File.Open(FilePath, FileMode.Create))
            {
                WriteContents(stream, contents);
            }
        }
     }
}
