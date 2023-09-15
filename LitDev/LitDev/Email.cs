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

using System;
using System.Net.Mail;

namespace LitDev
{
    /// <summary>
    /// Email Methods.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDEmail
    {
        private static int port = 587;
        private static string server = "smtp.gmail.com";
        private static string from;
        private static string password;
        private static string to;
        private static string subject = "Email from SmallBasic";
        private static string body;
        private static string attachment;
        private static bool useSSL = true;

        private static MailMessage mail;
        private static SmtpClient SmtpServer;
        private static double lastSent = 0;

        /// <summary>
        /// SMTP port (default 587).
        /// </summary>
        public static Primitive Port { get { return port; } set { port = value; } }
        /// <summary>
        /// SMTP server (default "smtp.gmail.com").
        /// </summary>
        public static Primitive Server { get { return server; } set { server = value; } }
        /// <summary>
        /// From email address.
        /// </summary>
        public static Primitive From { get { return from; } set { from = value; } }
        /// <summary>
        /// Email client password.
        /// </summary>
        public static Primitive Password { get { return password; } set { password = value; } }
        /// <summary>
        /// Recipient email address.
        /// </summary>
        public static Primitive Recipient { get { return to; } set { to = value; } }
        /// <summary>
        /// Subject text.
        /// </summary>
        public static Primitive Subject { get { return subject; } set { subject = value; } }
        /// <summary>
        /// Email body text.
        /// </summary>
        public static Primitive Body { get { return body; } set { body = value; } }
        /// <summary>
        /// Attachment file.
        /// </summary>
        public static Primitive Attachment { get { return attachment; } set { attachment = value; } }
        /// <summary>
        /// "True" or "False" (default "True").
        /// </summary>
        public static Primitive UseSSL { get { return useSSL; } set { useSSL = value; } }

        /// <summary>
        /// Send an email.
        /// The default Smtp client is "smtp.gmail.com" and the default port is 587.  The following and other email clients may also work.
        /// "smtp.live.com" (Hotmail)
        /// "smtp.mail.yahoo.com"
        /// 
        /// A minimum of the "From, Password and Recipient" properties must be set first.
        /// The "From" and "Password" properties should be your email credentials for the client.
        /// Additionally you should set the "Subject and Body" properties.
        /// The "Attachment" property may be optionally set to a full file path, "" for no attachment.
        /// 
        /// No more than 1 email per minute can be sent.
        /// </summary>
        /// <returns>"" for success or an error message.</returns>
        public static Primitive Send()
        {
            if ((Clock.ElapsedMilliseconds - lastSent) < 60 * 1000) return "Less than 1 minute since last email sent.";
            lastSent = Clock.ElapsedMilliseconds;
            string result = "";
            try
            {
                SmtpServer = new SmtpClient(server);
                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
                SmtpServer.EnableSsl = useSSL;

                mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = body;

                if (System.IO.File.Exists(attachment))
                {
                    mail.Attachments.Add(new System.Net.Mail.Attachment(attachment));
                }

                SmtpServer.Send(mail);
            }
            catch (SmtpException ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                result = Utilities.GetCurrentMethod() + " " + ex.Message;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                result = Utilities.GetCurrentMethod() + " " + ex.Message;
            }
            return result;
        }
    }
}
