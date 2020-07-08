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

using Microsoft.SmallBasic.Library;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// ftp Methods.
    /// </summary>
    [SmallBasicType]
    public static class LDftp
    {
        private static bool useBinary = true;
        private static bool doAssync = false;

        private static void DoUpload(Object obj)
        {
            FtpWebRequest reqFTP = (FtpWebRequest)((Object[])obj)[0];
            FileInfo fileInf = (FileInfo)((Object[])obj)[1];

            try
            {
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = useBinary;
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                reqFTP.ContentLength = fileInf.Length;

                int bufferSize = 2048;
                byte[] buffer = new byte[bufferSize];

                FileStream fs = fileInf.OpenRead();
                Stream ftpStream = reqFTP.GetRequestStream();
                int contentLen = fs.Read(buffer, 0, bufferSize);

                while (contentLen != 0)
                {
                    ftpStream.Write(buffer, 0, contentLen);
                    contentLen = fs.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                fs.Close();
                ftpResult = "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                ftpResult = "FAILED";
            }
            if (doAssync)
            {
                lock (lockFTP)
                {
                    lastFTPFile = reqFTP.RequestUri.AbsolutePath;
                    lastFTPStatus = ftpResult;
                    if (null != _FTPCompleteDelegate) _FTPCompleteDelegate();
                }
            }
        }

        private static void DoDownload(Object obj)
        {
            FtpWebRequest reqFTP = (FtpWebRequest)((Object[])obj)[0];
            FileInfo fileInf = (FileInfo)((Object[])obj)[1];

            try
            {
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = useBinary;
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;

                int bufferSize = 2048;
                byte[] buffer = new byte[bufferSize];

                FileStream fs = fileInf.OpenWrite();
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                int readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    fs.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                fs.Close();
                response.Close();
                ftpResult = "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                ftpResult = "FAILED";
            }
            if (doAssync)
            {
                lock (lockFTP)
                {
                    lastFTPFile = reqFTP.RequestUri.AbsolutePath;
                    lastFTPStatus = ftpResult;
                    if (null != _FTPCompleteDelegate) _FTPCompleteDelegate();
                }
            }
        }

        private static void DoDelete(Object obj)
        {
            FtpWebRequest reqFTP = (FtpWebRequest)((Object[])obj)[0];

            try
            {
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = useBinary;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
                ftpResult = "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                ftpResult = "FAILED";
            }
            if (doAssync)
            {
                lock (lockFTP)
                {
                    lastFTPFile = reqFTP.RequestUri.AbsolutePath;
                    lastFTPStatus = ftpResult;
                    if (null != _FTPCompleteDelegate) _FTPCompleteDelegate();
                }
            }
        }

        private static string ftpResult = "";
        private static Object lockFTP = new Object();
        private static SmallBasicCallback _FTPCompleteDelegate = null;
        private static string lastFTPFile = "";
        private static string lastFTPStatus = "";

        /// <summary>
        /// Event when an asynchronous ftp transfer completes.
        /// </summary>
        public static event SmallBasicCallback FTPComplete
        {
            add
            {
                _FTPCompleteDelegate = value;
            }
            remove
            {
                _FTPCompleteDelegate = null;
            }
        }

        /// <summary>
        /// The last asynchronous FTP file transfered.
        /// </summary>
        public static Primitive LastFTPFile
        {
            get { return lastFTPFile; }
        }

        /// <summary>
        /// The last asynchronous FTP file status ("SUCCESS" or "FAILED")
        /// </summary>
        public static Primitive LastFTPStatus
        {
            get { return lastFTPStatus; }
        }

        /// <summary>
        /// Set or get whether ftp transfers use binary (default) or ascii. ("True" or "False").
        /// </summary>
        public static Primitive UseBinary
        {
            get { return useBinary; }
            set { useBinary = value; }
        }

        /// <summary>
        /// Set or get whether ftp transfers are performed asynchronously ("True" or "False" default).
        /// An asynchronous ftp transfer will return immediately and complete in the background.
        /// The event FTPComplete will be called when the tranfer is finished.
        /// </summary>
        public static Primitive DoAssync
        {
            get { return doAssync; }
            set { doAssync = value; }
        }

        /// <summary>
        /// Upload a file by ftp.
        /// </summary>
        /// <param name="localFile">The full path to the local file to upload.</param>
        /// <param name="remoteFile">The full path (on server) to the remote file to upload.</param>
        /// <param name="ftpServerIP">The ftp server address (or IP).</param>
        /// <param name="ftpUserID">The user ID.</param>
        /// <param name="ftpPassword">The user password.</param>
        /// <returns>"SUCCESS", "FAILED" or "PENDING" for async.</returns>
        public static Primitive Upload(Primitive localFile, Primitive remoteFile, Primitive ftpServerIP, Primitive ftpUserID, Primitive ftpPassword)
        {
            try
            {
                FileInfo fileInf = new FileInfo(localFile);
                Uri uri = new Uri("ftp://" + ftpServerIP + "/" + remoteFile);
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                if (doAssync)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DoUpload));
                    thread.Start(new Object[] { reqFTP, fileInf });
                    return "PENDING";
                }
                else
                {
                    DoUpload(new Object[] { reqFTP, fileInf });
                    return ftpResult;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Download a file by ftp.
        /// </summary>
        /// <param name="localFile">The full path to the local file to download.</param>
        /// <param name="remoteFile">The full path (on server) to the remote file to download.</param>
        /// <param name="ftpServerIP">The ftp server address (or IP).</param>
        /// <param name="ftpUserID">The user ID.</param>
        /// <param name="ftpPassword">The user password.</param>
        /// <returns>"SUCCESS", "FAILED" or "PENDING" for async.</returns>
        public static Primitive Download(Primitive localFile, Primitive remoteFile, Primitive ftpServerIP, Primitive ftpUserID, Primitive ftpPassword)
        {
            try
            {
                FileInfo fileInf = new FileInfo(localFile);
                Uri uri = new Uri("ftp://" + ftpServerIP + "/" + remoteFile);
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                if (doAssync)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DoDownload));
                    thread.Start(new Object[] { reqFTP, fileInf });
                    return "PENDING";
                }
                else
                {
                    DoDownload(new Object[] { reqFTP, fileInf });
                    return ftpResult;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Delete a file by ftp.
        /// </summary>
        /// <param name="remoteFile">The full path (on server) to the remote file to delete.</param>
        /// <param name="ftpServerIP">The ftp server address (or IP).</param>
        /// <param name="ftpUserID">The user ID.</param>
        /// <param name="ftpPassword">The user password.</param>
        /// <returns>"SUCCESS", "FAILED" or "PENDING" for async.</returns>
        public static Primitive Delete(Primitive remoteFile, Primitive ftpServerIP, Primitive ftpUserID, Primitive ftpPassword)
        {
            try
            {
                Uri uri = new Uri("ftp://" + ftpServerIP + "/" + remoteFile);
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                if (doAssync)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DoDelete));
                    thread.Start(new Object[] { reqFTP });
                    return "PENDING";
                }
                else
                {
                    DoDelete(new Object[] { reqFTP });
                    return ftpResult;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get a remote folder listing by ftp (non async only).
        /// </summary>
        /// <param name="remoteFolder">The full path (on server) to the remote folder to list.</param>
        /// <param name="ftpServerIP">The ftp server address (or IP).</param>
        /// <param name="ftpUserID">The user ID.</param>
        /// <param name="ftpPassword">The user password.</param>
        /// <returns>An array of file and folder names or "FAILED".  The array is indexed by the file name and the value contains additional information.</returns>
        public static Primitive ListFiles(Primitive remoteFolder, Primitive ftpServerIP, Primitive ftpUserID, Primitive ftpPassword)
        {
            try
            {
                Uri uri = new Uri("ftp://" + ftpServerIP + "/" + remoteFolder + "/");

                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = useBinary;
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                StreamReader fs = new StreamReader(ftpStream);

                string line = fs.ReadLine();
                Primitive result = "";
                while (line != null)
                {
                    string[] data = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int pos = line.IndexOf(data.Last());
                    result[line.Substring(pos)] = line.Substring(0, pos);
                    line = fs.ReadLine();
                }

                response.Close();
                ftpStream.Close();
                fs.Close();
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
