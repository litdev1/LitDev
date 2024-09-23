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
using System.Collections.ObjectModel;
using System.Globalization;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace LitDev
{
    /// <summary>
    /// The Speech library allows text to be spoken and speech recognition.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDSpeech
    {
        static LDSpeech()
        {
            Instance.Verify();
        }

        static SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(CultureInfo.CurrentCulture);
        static Choices vocab = new Choices();
        static bool defaultVocab = true;
        static string lastSpoken = "";
        static float lastSpokenConfidence = 0;
        static SBCallback _SpeechRecognitionDelegate;
        static bool debugMode = false;
        static double babbleTimeout = recognizer.BabbleTimeout.TotalSeconds;
        static double initialSilenceTimeout = recognizer.InitialSilenceTimeout.TotalSeconds;
        static double endSilenceTimeout = recognizer.EndSilenceTimeout.TotalSeconds;
        static double endSilenceTimeoutAmbiguous = recognizer.EndSilenceTimeoutAmbiguous.TotalSeconds;

        static void _SpeechRecognitionEvent(Object sender, SpeechRecognizedEventArgs e)
        {
            lastSpoken = e.Result.Text;
            lastSpokenConfidence = e.Result.Confidence;
            _SpeechRecognitionDelegate();
        }
        static void _SpeechHypothesizedEvent(Object sender, SpeechHypothesizedEventArgs e)
        {
            lastSpoken = "HYPOTHESIED " + e.Result.Text;
            _SpeechRecognitionDelegate();
        }
        static void _SpeechDetectedEvent(Object sender, SpeechDetectedEventArgs e)
        {
            lastSpoken = "DETECTED";
            _SpeechRecognitionDelegate();
        }
        static void _RecognizeCompletedEvent(Object sender, RecognizeCompletedEventArgs e)
        {
            lastSpoken = "COMPLETED " + e.Result.Text;
            _SpeechRecognitionDelegate();
        }
        static void _SpeechRecognitionRejectedEvent(Object sender, SpeechRecognitionRejectedEventArgs e)
        {
            lastSpoken = "REJECTED " + e.Result.Text;
            _SpeechRecognitionDelegate();
        }
        
        static SBCallback _SpeechRecognition
        {
            get
            {
                return _SpeechRecognitionDelegate;
            }
            set
            {
                _SpeechRecognitionDelegate = value;
            }
        }

        static void SetGrammar()
        {
            recognizer.UnloadAllGrammars();
            if (defaultVocab)
            {
                recognizer.LoadGrammar(new DictationGrammar());
            }
            else
            {
                GrammarBuilder grammarBuilder = new GrammarBuilder();
                grammarBuilder.Culture = CultureInfo.CurrentCulture;
                grammarBuilder.Append(vocab);
                Grammar grammar = new Grammar(grammarBuilder);
                recognizer.LoadGrammar(grammar);
            }
        }

        static SpeechSynthesizer _speak = new SpeechSynthesizer();
        static int _volume = _speak.Volume;
        static int _speed = _speak.Rate;
        static string _voice = _speak.Voice.Name;

        /// <summary>
        /// Speed of speech (-10 to 10).
        /// </summary>
        public static Primitive Speed
        {
            get { return _speed; }
            set { _speed = System.Math.Min(10, System.Math.Max(-10, (int)value)); }
        }

        /// <summary>
        /// Volume of speech (0 to 100).
        /// </summary>
        public static Primitive Volume
        {
            get { return _volume; }
            set { _volume = System.Math.Min(100, System.Math.Max(0, (int)value)); }
        }

        /// <summary>
        /// Returns an array of available voices.
        /// </summary>
        /// <returns>
        /// An array of available voices.
        /// </returns>
        public static Primitive Voices()
        {
            ReadOnlyCollection<InstalledVoice> voices = _speak.GetInstalledVoices();
            string Voices = "";
            int count = 1;
            foreach (InstalledVoice i in voices)
            {
                Voices += count.ToString() + "=" + Utilities.ArrayParse(i.VoiceInfo.Name) + ";";
                count++;
            }
            return Utilities.CreateArrayMap(Voices);
        }

        /// <summary>
        /// The current voice.
        /// </summary>
        public static Primitive Voice
        {
            get { return _voice; }
            set { _voice = value; }
        }

        /// <summary>
        /// Speak some text.
        /// </summary>
        /// <param name="text">
        /// Text to be spoken.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Speak(Primitive text)
        {
            try
            {
                _speak.Rate = _speed;
                _speak.Volume = _volume;
                _speak.SelectVoice(_voice);
                _speak.Speak(text);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set a debug mode for speech regognition "True" or "False" (default) 
        /// Set before creating Listen event.
        /// This will send message "DETECTED" to Listen event when any speech noise is detected, even if it is not recognised in the vocabulary.
        /// </summary>
        public static Primitive DebugMode
        {
            get { return debugMode ? "True" : "False"; }
            set { debugMode = value; }
        }

        /// <summary>
        /// Time in seconds recogniser accepts input containing only background noise, default 0.
        /// </summary>
        public static Primitive BabbleTimeout
        {
            get { return babbleTimeout; }
            set { babbleTimeout = value; }
        }

        /// <summary>
        /// Time in seconds recogniser accepts input containing only silence, default 30.
        /// </summary>
        public static Primitive InitialSilenceTimeout
        {
            get { return initialSilenceTimeout; }
            set { initialSilenceTimeout = value; }
        }

        /// <summary>
        /// Time in seconds recogniser accepts silence after unambigous detection, default 0.15.
        /// </summary>
        public static Primitive EndSilenceTimeout
        {
            get { return endSilenceTimeout; }
            set { endSilenceTimeout = value; }
        }

        /// <summary>
        /// Time in seconds recogniser accepts silence after ambigous detection, default 0.5.
        /// </summary>
        public static Primitive EndSilenceTimeoutAmbiguous
        {
            get { return endSilenceTimeoutAmbiguous; }
            set { endSilenceTimeoutAmbiguous = value; }
        }

        /// <summary>
        /// Set a vocabulary of words and phrases for the speech regonition to use.
        /// If this is unset, then a large language vocabulary is used and the results will generally be less good (unusable).
        /// Also distinct phrases can have a better recognition than single words.
        /// </summary>
        /// <param name="dictionary">
        /// An array of words or phrases to be recognised.
        /// If it is empty, then the default language vocabulary is used.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Vocabulary(Primitive dictionary)
        {
            vocab = new Choices();
            string[] stringSeparators = new string[] { ";" };
            string[] lines = ((string)dictionary).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] records = line.Split('=');
                vocab.Add(new string[] {records[1]});
            }
            defaultVocab = lines.Length == 0;
        }

        /// <summary>
        /// Event when speech is spoken (and recognised) by the computer.
        /// A good microphone, lots of training or consise dictionary are needed to get decent results.
        /// </summary>
        public static event SBCallback Listen
        {
            add
            {
                _SpeechRecognition = value;
                try
                {
                    recognizer = new SpeechRecognitionEngine(CultureInfo.CurrentCulture);
                    SetGrammar();
                    recognizer.BabbleTimeout = TimeSpan.FromSeconds(babbleTimeout);
                    recognizer.InitialSilenceTimeout = TimeSpan.FromSeconds(initialSilenceTimeout);
                    recognizer.EndSilenceTimeout = TimeSpan.FromSeconds(endSilenceTimeout);
                    recognizer.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(endSilenceTimeoutAmbiguous);
                    recognizer.SetInputToDefaultAudioDevice();
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                    recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_SpeechRecognitionEvent);
                    if (debugMode)
                    {
                        recognizer.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(_SpeechHypothesizedEvent);
                        recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_SpeechDetectedEvent);
                        recognizer.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(_RecognizeCompletedEvent);
                        recognizer.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(_SpeechRecognitionRejectedEvent);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            remove
            {
                _SpeechRecognition = null;
            }
        }

        /// <summary>
        /// Text of the last speech spoken (and recognised) by the computer.
        /// </summary>
        public static Primitive LastSpoken
        {
            get { return lastSpoken; }
        }

        /// <summary>
        /// The last speech spoken detection confidence of correctness (0 to 1).
        /// </summary>
        public static Primitive LastSpokenConfidence
        {
            get { return lastSpokenConfidence; }
        }
    }
}
