//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System;
using System.Reflection;
using System.Windows.Media;
using Microsoft.SmallBasic.Library.Internal;
using System.Media;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// A Sound Recorder.  A microphone (may be internal) is required.
    /// System sounds can also be played (if they are set appropriately).
    /// </summary>
    [SmallBasicType]
    public static class LDSound
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool Beep(uint dwFreq, uint dwDuration);
        
        private static bool bRecording = false;

        /// <summary>
        /// Start recording sound.
        /// </summary>
        public static void Start()
        {
            if (bRecording) mciSendString("close recsound ", "", 0, 0);
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            bRecording = true;
        }

        /// <summary>
        /// Stop and save current sound recording.
        /// </summary>
        /// <param name="wavFile">The full path to a wav file to save the recording.
        /// The extension will be set to ".wav" if it is not already.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive Stop(Primitive wavFile)
        {
            if (!bRecording) return "FAILED";
            wavFile = Path.ChangeExtension(wavFile, ".wav");
            Utilities.ClearMediaPlayer(wavFile);
            wavFile = "\"" + wavFile + "\"";
            int iRet = 0;
            iRet |= mciSendString("save recsound " + wavFile, "", 0, 0);
            iRet |= mciSendString("close recsound ", "", 0, 0);
            bRecording = false;
            return iRet == 0 ? "SUCCESS" : "FAILED";
        }

        /// <summary>
        /// Pause a recording.
        /// </summary>
        public static void Pause()
        {
            if (!bRecording) return;
            mciSendString("pause recsound ", "", 0, 0);
        }

        /// <summary>
        /// Resume a paused recording.
        /// </summary>
        public static void Resume()
        {
            if (!bRecording) return;
            mciSendString("resume recsound ", "", 0, 0);
        }

        /// <summary>
        /// Play system Asterisk sound.
        /// </summary>
        public static void Asterisk()
        {
            SystemSounds.Asterisk.Play();
        }

        /// <summary>
        /// Play system Beep sound.
        /// </summary>
        public static void Beep()
        {
            SystemSounds.Beep.Play();
        }

        /// <summary>
        /// Play system Exclamation sound.
        /// </summary>
        public static void Exclamation()
        {
            SystemSounds.Exclamation.Play();
        }

        /// <summary>
        /// Play system Hand sound.
        /// </summary>
        public static void Hand()
        {
            SystemSounds.Hand.Play();
        }

        /// <summary>
        /// Play system Question sound.
        /// </summary>
        public static void Question()
        {
            SystemSounds.Question.Play();
        }

        /// <summary>
        /// Play a system tone sound with frequency and duration.
        /// Uses the motherboard speaker (not the sound card) and may be low quality or not available.
        /// </summary>
        /// <param name="frequency">The tone frequency (from 37 to 32767 Hz).</param>
        /// <param name="duration">The tone duration in ms.</param>
        public static void Tone(Primitive frequency, Primitive duration)
        {
            Console.Beep(frequency, duration);
        }
    }
}
