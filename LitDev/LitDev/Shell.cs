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

// Shell extension originally by Pappa Lapub

/* https://stackoverflow.com/questions/5708434/how-to-use-shell32-within-a-c-sharp-application
 How to use Shell32 within a C# application?
 reference "Microsoft Shell command and automation"

 http://msdn.microsoft.com/library/windows/desktop/bb774094.aspx	Shell object
 http://technet.microsoft.com/en-us/library/ee176615.aspx			Retrieving Extended File Properties 
 http://msdn.microsoft.com/library/windows/desktop/bb787870.aspx
 http://msdn.microsoft.com/library/bb787870.aspx					Folder.GetDetailsOf method

 http://de.scribd.com/doc/3860189/Scripting-QTP-CH11-Shell32		veraltet, ist ..
 http://www.onestopqa.com/resources/Working%20with%20Shell32.pdf	""
 http://wsh2.uw.hu/ch14h.html	The Windows Shell (Günter Born)
 http://borncity.com/, http://borncity.com/net-corner/ (http://www.borncity.de/Net/Index.htm)
 http://www.borncity.com/web/WSHBazaar1/index.htm, http://www.borncity.com/web/WSHBazaar1/

 ToDo: entfernen in GetDetail, GetDetailInfo
 AudioShell 1.3.5
 www.softpointer.com/AudioShell.htm
 und/oder
 (Provided by InfoTag Magic)
 In GetAllDetailsFor, GetDetailInfo, GetDetail endenden '\' entfernen bei Ordnerpfad
 if(Microsoft.SmallBasic.Library.Text.EndsWith(parent, "\\")) parent = parent.Remove(parent.Length - 1, 1);
 bzw. char[] charsTrim = {' ', '\''};
      fo = fo.Trim(charsTrim);
 In SelectFolder Standard Startordner festlegen für "", zB. C:\
 
  2 Methoden hinzufügen:
  public static Primitive ShellLinkGet		wie LinkGetProperty, mit IWshRuntimeLibrary
  public static Primitive ShellLinkSet		wie LinkSetProperty, mit IWshRuntimeLibrary
  
  ToDo: *Infotip Einblendungen entfernen unter GetDetail, GetDetailInfo:	3x OK
		1. alte AudioShell 1.3.5	Kommentar:
		  www.softpointer.com/AudioShell.htm
		2. (Provided by InfoTag Magic)
		3. Einblendung durch Quizo QTTabBar checken
	*In GetAllDetailsFor, GetDetailInfo, GetDetail endenden '\' für Ordnerpfad entfernen	OK
	*In SelectFolder Standard Startordner festlegen für "", zB. C:\		OK
	*ShellLinkGet/-Set		wie LinkGetProperty/LinkSetProperty, aber mit IWshRuntimeLibrary	OK
	*Elternordner öffenen für Dateipfad in ExploreFolder, OpenFolder	OK
	*mit lastFolder öffnen wenn initDir == ""  in SelectFolder			OK
	*Shell Service Methoden nach SBService								OK
	*SpecialFolderConstants -> Array mit "clsid=Ordnername;"			OK
	*GetSetting   ändern für HEX Eingabe
*/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;		// DTIcons, PropsDlg, RecycleBin (DllImport)
using System.Globalization;
using System.Reflection;					// Name, Version, Attributes
using Shell32 = Interop.Shell32;				// Shortcut, SpecialFolderList	(tlbimp.exe Shell32.dll, Interop.Shell32.dll)
using IWshRuntimeLibrary;					// Shortcut  (tlbimp.exe wshom.ocx, IWshRuntimeLibrary.dll)

namespace LitDev
{
    /// <summary>Functions for extended file infos, LNK/URL shortcuts and Shell apps. (All code and methods provided by Pappa Lapub).</summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDShell
    {
        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/b25e2b8f-141a-4a1c-a73c-1cb92f953b2b/instantiate-shell32shell-object-in-windows-8?forum=clr
        // http://nerdynotes.blogspot.no/2008/06/vbnet-shell32-code-compiled-on-vista.html
        private static Shell32.Folder GetShell32NameSpace(Object folder)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }

        // not used
        private static bool IsNumber(string input)
        { return Regex.Match(input, @"(-)?(\d)").Success; }

        private static bool IsNumeric(string input)
        {
            decimal value;
            return decimal.TryParse((string)input, NumberStyles.Float, CultureInfo.InvariantCulture, out value) ? true : false;
        }

        private static string lastFolder = null;

        // To remove advertisements from InfoTip when InfotagMagic (http://www.contextmagic.com/audiotag-editor/)
        // or old AudioShell 1.3.5 (http://www.softpointer.com/AudioShell.htm) installed (for new AudioShell 2.2 ??, not tried) 
        private const string strItag = "\r\n\\(Provided by InfoTag Magic\\)";
        private const string strAShell = "AudioShell 1.3.5\r\nwww.softpointer.com/AudioShell.htm\r\n";	// \r\n....
        private const string strAShellSep = "\r\n---------------------------------------------\r\n";

        /// <summary>Gets the value of an extended property for a given file or folder.</summary>
        /// <param name="path">The full file- or folder path.</param>
        /// <param name="infoType">The ID number or name of the property (eg. -1="Infotip"/"", 0="Name", 1="Size", etc.)
        /// ID numbers and names of available properties under s. 'AllDetails'.</param>
        /// <returns>The value of the property if available, else "". "FAILED" on failure (eg. missing path).
        /// Infotip lines separated by lf and ending with crlf.</returns>
        public static Primitive GetDetail(Primitive path, Primitive infoType)
        {
            string fo = Environment.ExpandEnvironmentVariables(path);
            if (!System.IO.File.Exists(fo) && !Directory.Exists(fo)) return "FAILED";
            char[] charsTrim = { ' ', '\'' };
            fo = fo.Trim(charsTrim);

            string strTyp = infoType;
            if (String.IsNullOrEmpty(strTyp)) strTyp = "Infotip";
            int itNo = -1;
            string strDetail = "";
            string fDir = Path.GetDirectoryName(fo);
            string fNameExt = Path.GetFileName(fo);
            string header;

            try
            {
                Shell32.Folder fold = GetShell32NameSpace(fDir);
                Shell32.FolderItem foldItem = fold.ParseName(fNameExt);

                if (IsNumber(strTyp))
                {
                    itNo = Convert.ToInt32(strTyp);
                }
                else
                {
                    for (int i = 0; i <= 316; i++)	// 286	(Win7)
                    {
                        header = fold.GetDetailsOf(fold.Items(), i).ToString();
                        if (String.Compare(strTyp, header, true) == 0)
                        {
                            itNo = i;
                            break;
                        }
                    }
                }

                strDetail = fold.GetDetailsOf(foldItem, itNo).ToString();
                strDetail = Regex.Replace(strDetail, @"[\u200E\u200F\u202A\u202C]", string.Empty, RegexOptions.CultureInvariant);
                strDetail = Regex.Replace(strDetail, strItag, string.Empty, RegexOptions.CultureInvariant);
                strDetail = Regex.Replace(strDetail, strAShellSep, string.Empty, RegexOptions.CultureInvariant);
                strDetail = Regex.Replace(strDetail, strAShell, string.Empty, RegexOptions.CultureInvariant);
                return strDetail;
            }
            catch
            { return strDetail; }
        }

        /// <summary>Gets all available extended properties as Array ("idx=property name;", where -1=Infotip, 0=Name, .. up to 286=Total bitrate (or ev. ?Full bitrate? on engl systems)).</summary>
        public static Primitive AllDetails
        {
            get
            {
                Primitive details = new Primitive();
                details[-1] = @"Infotip";
                string prop;

                Shell32.Folder fold = GetShell32NameSpace(@"C:\");
                for (int i = 0; i <= 316; i++)	// 286	(Win7)
                {
                    prop = fold.GetDetailsOf(null, i);
                    if (String.IsNullOrEmpty(prop)) break;
                    details[i] = prop;
                }
                return details;
            }
        }

        /// <summary>Gets all available extended properties for the given file or folder as Array (up to max. 316, without -1=Infotip).</summary>
        /// <param name="path">The full file- or folder path.</param>
        /// <returns>All available extended properties as Array ("property name=value;...", without Infotip) on success, else "FAILED".</returns>
        public static Primitive GetAllDetailsFor(Primitive path)
        {
            string fo = Environment.ExpandEnvironmentVariables(path);
            if (!System.IO.File.Exists(fo) && !Directory.Exists(fo)) return "FAILED";
            char[] charsTrim = { ' ', '\'' };
            fo = fo.Trim(charsTrim);

            string prop;
            string header;
            Primitive details = new Primitive();
            string fDir = Path.GetDirectoryName(fo);
            string fNameExt = Path.GetFileName(fo);

            try
            {
                Shell32.Folder fold = GetShell32NameSpace(fDir);
                Shell32.FolderItem foldItem = fold.ParseName(fNameExt);

                for (int i = 0; i <= 316; i++)	// 286	(Win7)
                {
                    prop = fold.GetDetailsOf(foldItem, i).ToString();
                    if (!String.IsNullOrEmpty(prop))
                    {
                        header = fold.GetDetailsOf(fold.Items(), i).ToString();
                        prop = Regex.Replace(prop, @"[\u200E\u200F\u202A\u202C]", string.Empty, RegexOptions.CultureInvariant);
                        details[header] = prop;
                    }
                }
                return details;
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Gets the names of all available extended properties for a given file or folder as Array (up to max. 316, w/o -1=Infotip).</summary>
        /// <param name="path">The full file- or folder path.</param>
        /// <param name="step1">Indizes in speps by 1?  "True" or "False" (default, real property ID).</param>
        /// <returns>The names of all available extended properties as Array ("idx=property name;...", w/o Infotip) on success, else "FAILED".</returns>
        public static Primitive GetAllDetailNamesFor(Primitive path, Primitive step1)
        {
            string fo = Environment.ExpandEnvironmentVariables(path);
            if (!System.IO.File.Exists(fo) && !Directory.Exists(fo)) return "FAILED";
            char[] charsTrim = { ' ', '\'' };
            fo = fo.Trim(charsTrim);

            string prop;
            string header;
            Primitive details = new Primitive();
            string fDir = Path.GetDirectoryName(fo);
            string fNameExt = Path.GetFileName(fo);

            try
            {
                Shell32.Folder fold = GetShell32NameSpace(fDir);
                Shell32.FolderItem foldItem = fold.ParseName(fNameExt);

                for (int i = 0; i <= 316; i++)	// 286	(Win7)
                {
                    prop = fold.GetDetailsOf(foldItem, i).ToString();
                    if (!String.IsNullOrEmpty(prop))
                    {
                        header = fold.GetDetailsOf(fold.Items(), i).ToString();
                        if (step1)
                            details[details.GetItemCount() + 1] = header;
                        else
                            details[i] = header;
                    }
                }
                return details;
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Gets all available Verbs (contextmenu items) for a given filetype or folder as Array.
        /// Applying of a Verb on file/folder under see 'ApplyVerbOn'.</summary>
        /// <param name="path">The full file- or folder path.</param>
        /// <returns>All available Verbs as Array ("idx=verb;...", w/o '&amp;') on success, else "FAILED".</returns>
        public static Primitive GetAllVerbsFor(Primitive path)
        {
            string fo = Environment.ExpandEnvironmentVariables(path);
            if (!System.IO.File.Exists(fo) && !Directory.Exists(fo)) return "FAILED";
            char[] charsTrim = { ' ', '\'' };
            fo = fo.Trim(charsTrim);

            string fDir = Path.GetDirectoryName(fo);
            string fNameExt = Path.GetFileName(fo);
            Primitive result = new Primitive();
            try
            {
                Shell32.Folder fold = GetShell32NameSpace(fDir);
                Shell32.FolderItem foldItem = fold.ParseName(fNameExt);
                Shell32.FolderItemVerbs verbs = foldItem.Verbs();

                for (int i = 0; i < verbs.Count; i++)
                {
                    Shell32.FolderItemVerb vrb = verbs.Item(i);
                    string verbName = vrb.Name.Replace(@"&", string.Empty);
                    if (verbName.Length > 0) result[result.GetItemCount() + 1] = verbName;
                }
                return result;
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Apply the given Verb (contextmenu item) for the given file or folder.
        /// List of available Verbs (for a filetype or folder) under 'GetAllVerbsFor'.</summary>
        /// <param name="path">The full file- or folder path.</param>
        /// <param name="verb">The Verb to apply (case- and '&amp;' insensitive).</param>
        /// <returns>"SUCCESS" on success, else "FAILED".</returns>
        public static Primitive ApplyVerbOn(Primitive path, Primitive verb)
        {
            string vUse = verb;
            if (vUse.Length == 0) return "FAILED";
            vUse = vUse.Replace(@"&", string.Empty).ToLower();
            string fo = Environment.ExpandEnvironmentVariables(path);
            if (!System.IO.File.Exists(fo) && !Directory.Exists(fo)) return "FAILED";
            char[] charsTrim = { ' ', '\'' };
            fo = fo.Trim(charsTrim);

            string fDir = Path.GetDirectoryName(fo);
            string fNameExt = Path.GetFileName(fo);
            try
            {
                Shell32.Folder fold = GetShell32NameSpace(fDir);
                Shell32.FolderItem foldItem = fold.ParseName(fNameExt);
                Shell32.FolderItemVerbs verbs = foldItem.Verbs();

                for (int i = 0; i < verbs.Count; i++)
                {
                    Shell32.FolderItemVerb vrb = verbs.Item(i);
                    string verbName = vrb.Name.Replace(@"&", string.Empty).ToLower();
                    if (verbName.Equals(vUse))
                    {
                        vrb.DoIt();
                        return "SUCCESS";
                    }
                }
                return "FAILED";
            }
            catch { return "FAILED"; }
        }


        /// <summary>Gets properties of a lnk/url shortcut link, like target pfad, arguments etc.</summary>
        /// <param name="shortcut">The full path of the lnk/url shortcut link file.</param>
        /// <param name="property">The property to get (case independent, * for Urls) like:
        /// "Target"  target path *
        /// "Args"    arguments
        /// "Folder"  working directory
        /// "Desc"    comment *
        /// "HotKey"  shortcut key comb * (default: 0)
        /// "Style"   window style * (1 normal, 3 max, 7 min)
        /// "Icon"    icon path</param>
        /// <returns>The value of the property if available or "". "FAILED" on failure.</returns>
        public static Primitive LinkGetProperty(Primitive shortcut, Primitive property)
        {
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            if (!System.IO.File.Exists(scPath)) return "FAILED";
            string prop = property;
            string nIcon;
            int icoIdx = 0;
            string scDir = Path.GetDirectoryName(scPath);
            string scFNameExt = Path.GetFileName(scPath);

            try
            {
                Shell32.Folder fold = GetShell32NameSpace(scDir);
                Shell32.FolderItem foldItem = fold.ParseName(scFNameExt);
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)foldItem.GetLink;
                switch (prop.ToUpper())
                {
                    case "TARGET": return link.Path;
                    case "ARGS": return link.Arguments;
                    case "FOLDER": return link.WorkingDirectory;
                    case "DESC": return link.Description;
                    case "HOTKEY": return link.Hotkey;
                    case "STYLE": return link.ShowCommand;
                    case "ICON":
                        {
                            icoIdx = link.GetIconLocation(out nIcon);
                            return nIcon + "," + icoIdx.ToString();
                        }
                    default: return "FAILED";
                }
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Modifies properties of an existing lnk/url shortcut link, like target path, arguments etc. (* for Urls).</summary>
        /// <param name="shortcut">The full path of an existing lnk/url shortcut link file.</param>
        /// <param name="target">* The full path of the target file/-folder resp. URL address.</param>
        /// <param name="args">Startparameter when launching the shortcut or "" (for url).</param>
        /// <param name="folder">The full path of the start folder or "" (for url).</param>
        /// <param name="desc">* Comment or description for the shortcut or "".</param>
        /// <param name="icoPath">* Full path of the icon file for the shortcut or "".</param>
        /// <param name="icoIdx">* Index of the icon in the icon file (default: 0, for .ico).</param>
        /// <param name="hotkey">* keys combination to launch the shortcut link (default: 0).</param>
        /// <param name="style">* Window style when launching the shortcut (default: 1 normal, 3 max, 7 min).</param>
        /// <returns>The full file path of the modified shortcut on success, else "FAILED".</returns>
        public static Primitive LinkSetProperty(Primitive shortcut, Primitive target, Primitive args, Primitive folder, Primitive desc, Primitive icoPath, Primitive icoIdx, Primitive hotkey, Primitive style)
        {
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            if (!System.IO.File.Exists(scPath)) { return "FAILED"; }
            else
            {
                string scDir = Path.GetDirectoryName(scPath);
                string scFNameExt = Path.GetFileName(scPath);

                Shell32.Folder fold = GetShell32NameSpace(scDir);
                Shell32.FolderItem foldItem = fold.ParseName(scFNameExt);
                try
                {
                    Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)foldItem.GetLink;
                    link.Path = target;
                    link.Arguments = args;
                    link.WorkingDirectory = folder;
                    link.Description = desc;
                    link.Hotkey = hotkey;
                    link.ShowCommand = style;
                    link.SetIconLocation(icoPath, icoIdx);
                    link.Save(scPath);
                    return scPath;
                }
                catch
                { return "FAILED"; }
            }
        }

        /// <summary>Creates a new lnk/url shortcut (Shell32). Further editing with 'LinkSetProperty'.</summary>
        /// <param name="shortcut">The full path for the new lnk/url shortcut file.</param>
        /// <param name="target">The full path of the target file/-folder resp. URL address.</param>
        /// <returns>The full file path of the created shortcut on success, else "FAILED".</returns>
        public static Primitive LinkCreate(Primitive shortcut, Primitive target)
        {
            if (String.IsNullOrEmpty(target)) return "FAILED";
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            string scDir = Path.GetDirectoryName(scPath);
            if (!Directory.Exists(scDir)) return "FAILED";
            string scFNameExt = Path.GetFileName(scPath);

            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(scPath, false);
                sw.Close();

                Shell32.Folder fold = GetShell32NameSpace(scDir);
                Shell32.FolderItem foldItem = fold.ParseName(scFNameExt);
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)foldItem.GetLink;

                link.Path = target;
                link.Save(scPath);
                return scPath;
            }
            catch
            { return "FAILED"; }
        }


        /// <summary>Creates a new lnk/url shortcut (IWshRuntimeLibrary). Further editing with 'ShellLinkSet'.</summary>
        /// <param name="shortcut">The full path for the new lnk/url shortcut file.</param>
        /// <param name="target">The full path of the target file/-folder resp. URL address.</param>
        /// <returns>The full file path of the created shortcut on success, else "FAILED".</returns>
        public static Primitive ShellLink(Primitive shortcut, Primitive target)
        {
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            if (Path.GetExtension(scPath).ToLower() != ".lnk" && Path.GetExtension(scPath).ToLower() != ".url") return "FAILED";

            try
            {
                WshShell Shell = new WshShell();
                IWshShortcut link = (IWshShortcut)Shell.CreateShortcut(scPath);
                link.TargetPath = target;
                link.Save();
                return link.FullName;
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Gets properties of a lnk/url shortcut link, like target pfad, arguments etc. (IWshRuntimeLibrary).</summary>
        /// <param name="shortcut">The full path of the lnk/url shortcut link file.</param>
        /// <param name="property">The property to get (case independent, * for Urls) like:
        /// "Target"   target path *
        /// "Args"    arguments
        /// "Folder"  working directory
        /// "Desc"    comment *
        /// "HotKey"   shortcut key comb * (default: 0)
        /// "Style"   window style * (1 normal, 3 max, 7 min)
        /// "Icon"    icon path,Idx (default: ,0)</param>
        /// <returns>The value of the property if available or "". "FAILED" on failure.</returns>
        public static Primitive ShellLinkGet(Primitive shortcut, Primitive property)	// wie LinkGetProperty, mit IWshRuntimeLibrary
        {
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            if (!System.IO.File.Exists(scPath)) return "FAILED";
            string prop = property;

            try
            {
                WshShell Shell = new WshShell();
                IWshShortcut link = (IWshShortcut)Shell.CreateShortcut(scPath);

                switch (prop.ToUpper())
                {
                    case "TARGET": return link.TargetPath;			// string
                    case "ARGS": return link.Arguments;			// string
                    case "FOLDER": return link.WorkingDirectory;	// string
                    case "DESC": return link.Description;		// string
                    case "ICON": return link.IconLocation;
                    case "HOTKEY": return link.Hotkey;				// int
                    case "STYLE": return link.WindowStyle;		// int
                    default: return "FAILED";
                }
            }
            catch
            { return "FAILED"; }
        }

        /// <summary>Modifies properties of an existing lnk/url shortcut link, like target path, arguments etc. (* for Urls) (IWshRuntimeLibrary).</summary>
        /// <param name="shortcut">The full path of an existing lnk/url shortcut link file.</param>
        /// <param name="target">* The full path of the target file/-folder resp. URL address.</param>
        /// <param name="args">Startparameter when launching the shortcut or "" (for url).</param>
        /// <param name="folder">The full path of the start folder or "" (for url).</param>
        /// <param name="desc">* Comment or description for the shortcut or "".</param>
        /// <param name="icon">* The full path (resp. path,Idx) of the icon for the shortcut link or "". 'Idx' is Index of the icon in in the file (default: 0, for .ico).</param>
        /// <param name="hotkey">* keys combination to launch the shortcut link (default: 0).</param>
        /// <param name="style">* Window style when launching the shortcut (default: 1 normal, 3 max, 7 min).</param>
        /// <returns>The full file path of the modified shortcut on success, else "FAILED".</returns>
        public static Primitive ShellLinkSet(Primitive shortcut, Primitive target, Primitive args, Primitive folder, Primitive desc, Primitive icon, Primitive hotkey, Primitive style)	// wie LinkSetProperty, mit IWshRuntimeLibrary
        {
            string scPath = Environment.ExpandEnvironmentVariables(shortcut);
            if (!System.IO.File.Exists(scPath)) { return "FAILED"; }

            try
            {
                WshShell Shell = new WshShell();
                IWshShortcut link = (IWshShortcut)Shell.CreateShortcut(scPath);

                if (!String.IsNullOrEmpty(target)) link.TargetPath = target;
                if (!String.IsNullOrEmpty(args)) link.Arguments = args;
                if (!String.IsNullOrEmpty(folder)) link.WorkingDirectory = folder;
                if (!String.IsNullOrEmpty(desc)) link.Description = desc;
                if (!String.IsNullOrEmpty(icon)) link.IconLocation = icon;
                if (!String.IsNullOrEmpty(hotkey)) link.Hotkey = hotkey;
                if (!String.IsNullOrEmpty(style)) link.WindowStyle = style;

                link.Save();
                return link.FullName;
            }
            catch
            { return "FAILED"; }
        }


        [DllImport("user32.dll")]	// [DllImport("user32.dll", CharSet=CharSet.Auto)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        /// <summary>Hides all desktop icons.</summary>
        public static void DTIconsHide()
        {
            IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
            if (IsWindowVisible(hWnd) == true) ShowWindow(hWnd, 0);
        }

        /// <summary>Shows all hidden desktop icons again.</summary>
        public static void DTIconsShow()
        {
            IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
            if (IsWindowVisible(hWnd) == false) ShowWindow(hWnd, 4);	// 5
        }

        /// <summary>Gets weather the desktop icons are currently visible ("True" or "False").</summary>
        public static Primitive DTIconsOn
        {
            get
            {
                IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
                return IsWindowVisible(hWnd);	// true-visible, false-hidden
            }
            set
            {
                IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
                if (value)
                {
                    if (IsWindowVisible(hWnd) == false) ShowWindow(hWnd, 4);
                }
                else
                {
                    if (IsWindowVisible(hWnd) == true) ShowWindow(hWnd, 0);
                }
            }
        }

        /// <summary>Toggles the view of all desktop icons automatically (On/Off).</summary>
        public static void DTIconsToggle()
        {
            IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
            if (IsWindowVisible(hWnd) == true) ShowWindow(hWnd, 0);
            //SBShell.DTIconsHide();
            else ShowWindow(hWnd, 4);	// 5
            //SBShell.DTIconsShow();
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential)]
        private struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }
        private const int SW_SHOW = 5;	// only if GW is initialized, not from TW, this responsible ??
        private const uint SEE_MASK_INVOKEIDLIST = 12;

        /// <summary>Opens the shell properties dialog for a given file or folder path (GW is needed for that, not available from TW or Console).</summary>
        /// <param name="filePath">The full file- or folder path.</param>
        public static void ShowFileProperties(Primitive filePath)
        {
            string fileName = Environment.ExpandEnvironmentVariables(filePath);
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = fileName;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            ShellExecuteEx(ref info);
        }

        //Creates a structure for RecBin query Infos.
        [StructLayout(LayoutKind.Sequential, Pack = 4)]	// CharSet.Unicode, Pack = 1
        private struct SHQUERYRBINFO
        {
            public uint cbSize;			// Int32, uint
            public long i64Size;		// UInt64
            public long i64NumItems;	// UInt64
        }

        // Call SHQueryRecycleBin Methode in shell32.dll to query filesize and -count in RecBin.
        [DllImport("shell32.dll")]	// CharSet = CharSet.Unicode
        private static extern int SHQueryRecycleBin(string pszRootPath, ref SHQUERYRBINFO pSHQueryRBInfo);

        /// <summary>Gets all items in a special system/shell folder (upper level only).</summary>
        /// <param name="csidl">The CSIDL number of the system folder (0 to 47, constants and names of available folders under s. SpecialFolderConstants).</param>
        /// <returns>The names of all objects in the system folder as Array (only upper level) on success, else "FAILED".</returns>
        /// <example>http://msdn.microsoft.com/library/bb774096.aspx
        /// eg. CSIDL for:
        ///  3 Control panel
        ///  5 my documents
        ///  8 Recent
        ///  9 SendTo
        /// 10 RecBin
        /// 16 Desktop folder
        /// 17 Computer
        /// 20 Fonts
        /// 32 Temp Inet Files</example>
        public static Primitive SpecialFolderList(Primitive csidl)
        {
            int nFold = csidl;
            if (nFold < 0 || nFold > 47) return "FAILED";
            string itemName;
            Primitive content = new Primitive();

            try
            {
                Shell32.Folder fold = GetShell32NameSpace(nFold);
                Shell32.FolderItems foldItems = fold.Items();

                foreach (Shell32.FolderItem item in foldItems)
                {
                    itemName = item.Name;	//Path;
                    if (Path.GetExtension(itemName) == "") itemName += Path.GetExtension(item.Path);
                    // //Necessary for systems with hidden file extensions.
                    content[content.GetItemCount() + 1] = itemName;
                }
                return content;
            }
            catch
            { return "FAILED"; }
        }

        // http://msdn.microsoft.com/library/bb774096.aspx	ShellSpecialFolderConstants enum
        /// <summary>Gets a list of all CSIDL numbers and their according special System-/Shell folder names as Array ("csidl=folder name;").</summary>
        public static Primitive SpecialFolderConstants
        {
            get
            {
                Primitive specDirConst = new Primitive();
                try
                {
                    for (int i = 0; i <= 47; i++)
                    {
                        Shell32.Folder fold = GetShell32NameSpace(i);
                        if (fold != null)
                        {
                            specDirConst[i] = fold.Title;
                        }
                    }
                    return specDirConst;
                }
                catch
                { return "FAILED"; }
            }
        }

        /// <summary>Gets a list of all special System-/Shell folder names and their according folder paths as Array ("folder name=path;").</summary>
        public static Primitive SpecialFolderPaths
        {
            get
            {
                Primitive specDirPath = new Primitive();
                try
                {
                    for (int i = 0; i <= 47; i++)
                    {
                        Shell32.Folder fold = GetShell32NameSpace(i);
                        Shell32.Folder2 fold2 = (Shell32.Folder2)GetShell32NameSpace(i);

                        if (fold != null && fold2 != null)
                        {
                            Shell32.FolderItem foldItem = fold2.Self;
                            specDirPath[fold.Title] = foldItem.Path;
                        }
                    }
                    return specDirPath;
                }
                catch
                { return "FAILED"; }
            }
        }

        /// <summary>Gets a list of all special System folders as Array ("folder name=path;"). For Shell folders s. 'SpecialFolderPaths'.</summary>
        public static Primitive SpecialFolders
        {
            get
            {
                Primitive specDirs = new Primitive();
                foreach (Environment.SpecialFolder sf in Enum.GetValues(typeof(Environment.SpecialFolder)))
                { specDirs[sf.ToString()] = Environment.GetFolderPath(sf); }
                return specDirs;
            }
        }


        /// <summary>Minimizes all opened windows into the taskbar and showes the desktop (Revert with RestoreWindows).</summary>
        public static void ShowDesktop()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.MinimizeAll();
        }

        /// <summary>Orders all opened windows horizontally tiled on the desktop (Revert with RestoreWindows).</summary>
        public static void TileAllHoriz()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.TileHorizontally();
        }

        /// <summary>Orders all opened windows vertically tiled on the desktop (Revert with RestoreWindows).</summary>
        public static void TileAllVert()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.TileVertically();
        }

        /// <summary>Orders all opended windows in cascades on the desktop (Revert with RestoreWindows).</summary>
        public static void CascadeWindows()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.CascadeWindows();
        }

        /// <summary>Restores all minimized windows in the taskbar (after ShowDesktop, TileAll.., CascadeWindows) again.</summary>
        public static void RestoreWindows()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.UndoMinimizeALL();
        }

        /// <summary>Toggles the view of the (windowless) desktop on and off (s. ShowDesktop/RestoreWindows).</summary>
        public static void ToggleDesktop()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.ToggleDesktop();
        }

        /// <summary>Orders all opended windows in a 3D stack on the desktop to select through (with arrow keys).</summary>
        public static void Switch3D()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.WindowSwitcher();
        }

        /// <summary>Shows the Run(box) Dialog.</summary>
        public static void RunBox()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.FileRun();
        }

        /// <summary>Shows the dialog for date- and time settings.</summary>
        public static void DateTimeSettings()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.SetTime();
        }

        /// <summary>Shows the dialog for startmenü/taskbar settings.</summary>
        public static void StartSettings()
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.TrayProperties();
        }

        /// <summary>Opens a specified folder in a Windows Explorer window. (parent folder for existing file path). In new tab in QTTabBar.</summary>
        /// <param name="path">The folder path to open in explorer (file path opens parent folder). The folder must exist.</param>
        public static void ExploreFolder(Primitive path)
        {
            string dir;
            if (String.IsNullOrEmpty(path)) dir = Program.Directory;
            else dir = Environment.ExpandEnvironmentVariables(path);

            if (System.IO.File.Exists(dir)) dir = Path.GetDirectoryName(dir);
            if (Directory.Exists(dir))
            {
                Shell32.Shell shell = new Shell32.Shell();
                shell.Explore(dir);
            }
        }

        /// <summary>Opens explorer with the given file-/folder path (parent folder for existing file path). In new tab in QTTabBar.</summary>
        /// <param name="path">Opens the specified folder (file path opens parent folder). The folder must exist.</param>
        public static void OpenFolder(Primitive path)
        {
            string dir;
            if (String.IsNullOrEmpty(path)) dir = Program.Directory;
            else dir = Environment.ExpandEnvironmentVariables(path);

            if (System.IO.File.Exists(dir)) dir = Path.GetDirectoryName(dir);
            if (Directory.Exists(dir))
            {
                Shell32.Shell shell = new Shell32.Shell();
                shell.Open(dir);
            }
        }

        /// <summary>Shows a folder selection dialog.</summary>
        /// <param name="title">The title to show on the dialog.</param>
        /// <param name="initDir">The start folder when the dialog opens or "" for last selected folder (default: Computer).</param>
        /// <returns>The full folder path after selection or "" when canceled, else "FAILED".</returns>
        public static Primitive SelectFolder(Primitive title, Primitive initDir)
        {
            string result = "";
            string iDir = lastFolder;
            if (!String.IsNullOrEmpty(initDir)) iDir = initDir;

            if (!Directory.Exists(initDir)) iDir = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                Shell32.Folder2 fold = (Shell32.Folder2)shell.BrowseForFolder(0, (string)title, 0x10, (string)iDir);
                if (fold == null) return string.Empty;
                result = fold.Self.Path;
                lastFolder = result;
                return result;
            }
            catch
            { return "FAILED"; }
        }

        // http://msdn.microsoft.com/library/windows/desktop/gg537740.aspx		Shell.GetSystemInformation method
        /// <summary>Gets a given Systeminformation.</summary>
        /// <param name="info">The name of the value to get. Options:
        /// "DirectoryServiceAvailable", "DoubleClickTime", "ProcessorLevel", "ProcessorSpeed", "ProcessorArchitecture", "PhysicalMemoryInstalled", "IsOS_DomainMember"
        /// (Only XP: "IsOS_Professional", "IsOS_Personal").</param>
        /// <returns>The queried value on success, else "" or "FAILED".</returns>
        public static Primitive GetSystemInfo(Primitive info)
        {
            string val = info;
            if (string.IsNullOrEmpty(val)) return "FAILED";
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                var objShell = shell;
                return objShell.GetSystemInformation(val.Trim()).ToString();
            }
            catch
            { return "FAILED"; }
        }

        // UNSURE if the returned values are really correct, resp. which values are returned at all from "1", "2", "4" etc.
        // http://msdn.microsoft.com/library/windows/desktop/gg537739.aspx		Shell.GetSetting method
        /// <summary>Gets values for global Shell settings (s. folder opions-view, CheckedStatus).</summary>
        /// <param name="value">An integer constant for the value to get (eg. 1, 2, 4, "8", "32" etc.).</param>
        /// <returns>"True" or "False" on success, else "FAILED".</returns>
        /// <example>http://msdn.microsoft.com/library/windows/desktop/gg537739.aspx
        /// ShowAllObjects = SBShell.GetSetting(1)
        /// ShowExtensions = SBShell.GetSetting(2)
        /// ShowInfoTip = SBShell.GetSetting(8192)
        /// ShowSuperHidden = SBShell.GetSetting(262144)</example>
        public static Primitive GetSetting(Primitive value)
        {
            if (String.IsNullOrEmpty(value) || value < 1) return "FAILED";
            try
            {
                // http://dotnetdud.blogspot.co.at/2008/10/convert-string-to-long-using-c.html
                // long longStr = Int64.Parse(value);	// = Convert.ToInt64(value);
                Shell32.Shell shell = new Shell32.Shell();
                return shell.GetSetting(value);	// Convert.ToInt32((string)value, 16);
            }
            catch
            { return "FAILED"; }
        }


        /// <summary>Gets the current file version of this extension (else 0.0.0.0).</summary>
        public static Primitive Version
        {
            get
            { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }
        /// <summary>Gets the name of the executing assembly for this extension.</summary>
        public static Primitive Name
        {
            get
            { return Assembly.GetExecutingAssembly().GetName().Name; }
        }
    }
}
