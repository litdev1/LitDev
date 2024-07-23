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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// Extends the Sound.PlayMusic method to include a variety of instrument sounds.
    /// Also, multi-channel music can be created.
    /// Due to the large number of instrument names, it is easy to miss the following properties:
    /// Instrument, Velocity, Volume, Pan and Channel.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDMusic
    {
        private static IntPtr _midiOut = IntPtr.Zero;
        private const int NUMCHANNEL = 16;
        private static int _channel = 0;
        private static int[] _octave = new int[NUMCHANNEL];
        private static int[] _defaultLength = new int[NUMCHANNEL];
        private static int[] _velocity = new int[NUMCHANNEL];
        private static int[] _instrument = new int[NUMCHANNEL];
        private static int[] _volume = new int[NUMCHANNEL];
        private static int[] _pan = new int[NUMCHANNEL];

        [DllImport("winmm.dll")]
        private static extern int midiOutShortMsg(IntPtr midiOut, uint dwMsg);
        [DllImport("winmm.dll")]
        private static extern int midiOutSetVolume(IntPtr midiOut, uint dwVolume);
        [DllImport("winmm.dll")]
        private static extern int midiOutOpen(ref IntPtr midiOut, uint uDeviceID, IntPtr dwCallback, IntPtr dwCallbackInstance, uint dwFlags);
        [DllImport("winmm.dll")]
        private static extern int midiOutClose(IntPtr midiOutt);
        [DllImport("winmm.dll")]
        private static extern int midiOutReset(IntPtr midiOutt);

        private static Dictionary<string, int> _notes = new Dictionary<string, int>
		{
			{
				"C",
				0
			},
			
			{
				"C+",
				1
			},
			
			{
				"C#",
				1
			},
			
			{
				"D-",
				1
			},
			
			{
				"D",
				2
			},
			
			{
				"D+",
				3
			},
			
			{
				"D#",
				3
			},
			
			{
				"E-",
				3
			},
			
			{
				"E",
				4
			},
			
			{
				"F",
				5
			},
			
			{
				"F+",
				6
			},
			
			{
				"F#",
				6
			},
			
			{
				"G-",
				6
			},
			
			{
				"G",
				7
			},
			
			{
				"G+",
				8
			},
			
			{
				"G#",
				8
			},
			
			{
				"A-",
				8
			},
			
			{
				"A",
				9
			},
			
			{
				"A+",
				10
			},
			
			{
				"A#",
				10
			},
			
			{
				"B-",
				10
			},
			
			{
				"B",
				11
			}
		};

        private static void PlayNote(int octave, string note, int length, int channel)
        {
            double num = 1600.0 / (double)length;
            if (note == "P" || note == "R")
            {
                Thread.Sleep((int)num);
                return;
            }
            if (note == "L")
            {
                _defaultLength[channel] = length;
                return;
            }
            int num2;
            if (!_notes.TryGetValue(note, out num2))
            {
                num2 = 0;
            }
            octave = System.Math.Min(System.Math.Max(0, octave), 8);
            int number = octave * 12 + num2;
            PlayNote(number, channel);
            Thread.Sleep((int)num);
            StopNote(number, channel);
        }

        private static void PlayNotes(string song, int channel)
        {
            int i = 0;
            song = song.ToUpperInvariant();
            int length = song.Length;
            while (i < song.Length)
            {
                int num = _defaultLength[channel];
                char c = song[i++];
                if (char.IsLetter(c))
                {
                    string text = new string(c, 1);
                    if (i < length)
                    {
                        c = song[i];
                        if (c == '#' || c == '+' || c == '-')
                        {
                            text += new string(c, 1);
                            i++;
                        }
                        if (i < length)
                        {
                            c = song[i];
                            if (char.IsDigit(c))
                            {
                                num = (int)(c - '0');
                                i++;
                            }
                            if (i < length)
                            {
                                c = song[i];
                                if (char.IsDigit(c))
                                {
                                    num = num * 10 + (int)(c - '0');
                                    i++;
                                }
                            }
                        }
                    }
                    if (text[0] == 'O')
                    {
                        _octave[channel] = num;
                    }
                    else
                    {
                        PlayNote(_octave[channel], text, num, channel);
                    }
                }
                else
                {
                    if (c == '>')
                    {
                        _octave[channel] = System.Math.Min(8, _octave[channel] + 1);
                    }
                    else
                    {
                        if (c == '<')
                        {
                            _octave[channel] = System.Math.Max(0, _octave[channel] - 1);
                        }
                    }
                }
            }
        }

        private static void PlayNote(int number, int channel)
        {
            uint dwMsg = BitConverter.ToUInt32(new byte[]
            {
                (byte)(128+16 + channel),
                (byte)number,
                (byte)_velocity[channel],
                0
            }, 0);
            midiOutShortMsg(_midiOut, dwMsg);
        }

        private static void StopNote(int number, int channel)
        {
            uint dwMsg = BitConverter.ToUInt32(new byte[]
            {
                (byte)(128 + channel),
                (byte)number,
                (byte)_velocity[channel],
                0
            }, 0);
            midiOutShortMsg(_midiOut, dwMsg);
        }

        private static void ChangeInstrument(int number, int channel)
        {
            uint dwMsg = BitConverter.ToUInt32(new byte[]
	        {
		        (byte)(128+64 + channel),
		        (byte)number,
		        0,
		        0
	        }, 0);
            midiOutShortMsg(_midiOut, dwMsg);
        }

        private static void ChangePan(int number, int channel)
        {
            number = (int)System.Math.Min(127, System.Math.Max(0, (100 + number) / 200.0 * 127.0));
            uint dwMsg = BitConverter.ToUInt32(new byte[]
            {
                (byte)(128+32+16 + channel),
                (byte)(10),
                (byte)(number),
                0
            }, 0);
            midiOutShortMsg(_midiOut, dwMsg);
        }

        private static void ChangeVolume(int number, int channel)
        {
            number = (int)System.Math.Min(127, System.Math.Max(0, number / 100.0 * 127.0));
            uint dwMsg = BitConverter.ToUInt32(new byte[]
            {
                (byte)(128+32+16 + channel),
                (byte)(7),
                (byte)(number),
                0
            }, 0);
            midiOutShortMsg(_midiOut, dwMsg);
        }

        private static void EnsureDeviceInit()
        {
            if (_midiOut == IntPtr.Zero)
            {
                midiOutOpen(ref _midiOut, 0, IntPtr.Zero, IntPtr.Zero, 0u);
                for (int i = 0; i < NUMCHANNEL; i++)
                {
                    if (_octave[i] == 0) _octave[i] = 4;
                    if (_defaultLength[i] == 0) _defaultLength[i] = 4;
                    if (_velocity[i] == 0) _velocity[i] = 100;
                    if (_instrument[i] == 0) _instrument[i] = 0;
                    if (_volume[i] == 0) _volume[i] = 50;
                    if (_pan[i] == 0) _pan[i] = 0;
                }
            }
        }

        private static void ResetDevice()
        {
            if (_midiOut != IntPtr.Zero)
            {
                midiOutReset(_midiOut);
                ResetDefaults();
            }
        }

        private static void ResetDefaults()
        {
            for (int i = 0; i < NUMCHANNEL; i++)
            {
                _octave[i] = 4;
                _defaultLength[i] = 4;
                _velocity[i] = 100;
                _instrument[i] = 0;
                _volume[i] = 50;
                _pan[i] = 0;
            }
        }

        /// <summary>
        /// Plays musical notes.
        /// </summary>
        /// <param name="notes">
        /// A set of musical notes to play.  The format is a subset of the Music Markup Language supported by QBasic.
        /// </param>
        /// <example>
        /// <code>
        /// LDMusic.Instrument = LDMusic.Xylophone
        /// LDMusic.PlayMusic("O5 C8 C8 G8 G8 A8 A8 G4 F8 F8 E8 E8 D8 D8 C2")
        /// </code>
        /// </example>
        public static void PlayMusic(Primitive notes)
        {
            EnsureDeviceInit();
            int channel = _channel;
            ChangeInstrument(_instrument[channel], channel);
            ChangeVolume(_volume[channel], channel);
            ChangePan(_pan[channel], channel);
            PlayNotes(notes, channel);
        }

        /// <summary>
        /// Plays musical notes with specified instrument and MDI channel.
        /// Also set volume, pan (balance) and velocity (key hit speed).
        /// </summary>
        /// <param name="notes">
        /// A set of musical notes to play.  The format is a subset of the Music Markup Language supported by QBasic.
        /// </param>
        /// <param name="instrument"> The instrument number.</param>
        /// <param name="velocity"> The key velocity (1 to 128, default 100).</param>
        /// <param name="volume"> Volume (0 to 100, default 50).</param>
        /// <param name="pan"> Pan left (-100) or right (100) (default 0).</param>
        /// <param name="channel">The MIDI channel (1 to 16).</param>
        public static void PlayMusic2(Primitive notes, Primitive instrument, Primitive velocity, Primitive volume, Primitive pan, Primitive channel)
        {
            EnsureDeviceInit();
            channel = System.Math.Min(NUMCHANNEL - 1, System.Math.Max(0, channel - 1));
            _instrument[channel] = instrument - 1;
            _velocity[channel] = velocity - 1;
            ChangeInstrument(_instrument[channel], channel);
            ChangeVolume(volume, channel);
            ChangePan(pan, channel);
            PlayNotes(notes, channel);
        }

        /// <summary>
        /// Set the musical instrument (1 to 128).
        ///	1	Acoustic_Grand_Piano
        ///	2	Bright_Acoustic_Piano
        ///	3	Electric_Grand_Piano
        ///	4	Honky_tonk_Piano
        ///	5	Electric_Piano_1
        ///	6	Electric_Piano_2
        ///	7	Harpsichord
        ///	8	Clavi
        ///	9	Celesta
        ///	10	Glockenspiel
        ///	11	Music_Box
        ///	12	Vibraphone
        ///	13	Marimba
        ///	14	Xylophone
        ///	15	Tubular_Bells
        ///	16	Dulcimer
        ///	17	Drawbar_Organ
        ///	18	Percussive_Organ
        ///	19	Rock_Organ
        ///	20	Church_Organ
        ///	21	Reed_Organ
        ///	22	Accordion
        ///	23	Harmonica
        ///	24	Tango_Accordion
        ///	25	Acoustic_Guitar_nylon
        ///	26	Acoustic_Guitar_steel
        ///	27	Electric_Guitar_jazz
        ///	28	Electric_Guitar_clean
        ///	29	Electric_Guitar_muted
        ///	30	Overdriven_Guitar
        ///	31	Distortion_Guitar
        ///	32	Guitar_harmonics
        ///	33	Acoustic_Bass
        ///	34	Electric_Bass_finger
        ///	35	Electric_Bass_pick
        ///	36	Fretless_Bass
        ///	37	Slap_Bass_1
        ///	38	Slap_Bass_2
        ///	39	Synth_Bass_1
        ///	40	Synth_Bass_2
        ///	41	Violin
        ///	42	Viola
        ///	43	Cello
        ///	44	Contrabass
        ///	45	Tremolo_Strings
        ///	46	Pizzicato_Strings
        ///	47	Orchestral_Harp
        ///	48	Timpani
        ///	49	String_Ensemble_1
        ///	50	String_Ensemble_2
        ///	51	SynthStrings_1
        ///	52	SynthStrings_2
        ///	53	Choir_Aahs
        ///	54	Voice_Oohs
        ///	55	Synth_Voice
        ///	56	Orchestra_Hit
        ///	57	Trumpet
        ///	58	Trombone
        ///	59	Tuba
        ///	60	Muted_Trumpet
        ///	61	French_Horn
        ///	62	Brass_Section
        ///	63	SynthBrass_1
        ///	64	SynthBrass_2
        ///	65	Soprano_Sax
        ///	66	Alto_Sax
        ///	67	Tenor_Sax
        ///	68	Baritone_Sax
        ///	69	Oboe
        ///	70	English_Horn
        ///	71	Bassoon
        ///	72	Clarinet
        ///	73	Piccolo
        ///	74	Flute
        ///	75	Recorder
        ///	76	Pan_Flute
        ///	77	Blown_Bottle
        ///	78	Shakuhachi
        ///	79	Whistle
        ///	80	Ocarina
        ///	81	Lead_1_square
        ///	82	Lead_2_sawtooth
        ///	83	Lead_3_calliope
        ///	84	Lead_4_chiff
        ///	85	Lead_5_charang
        ///	86	Lead_6_voice
        ///	87	Lead_7_fifths
        ///	88	Lead_8_bass_lead
        ///	89	Pad_1_new_age
        ///	90	Pad_2_warm
        ///	91	Pad_3_polysynth
        ///	92	Pad_4_choir
        ///	93	Pad_5_bowed
        ///	94	Pad_6_metallic
        ///	95	Pad_7_halo
        ///	96	Pad_8_sweep
        ///	97	FX_1_rain
        ///	98	FX_2_soundtrack
        ///	99	FX_3_crystal
        ///	100	FX_4_atmosphere
        ///	101	FX_5_brightness
        ///	102	FX_6_goblins
        ///	103	FX_7_echoes
        ///	104	FX_8_sci_fi
        ///	105	Sitar
        ///	106	Banjo
        ///	107	Shamisen
        ///	108	Koto
        ///	109	Kalimba
        ///	110	Bag_pipe
        ///	111	Fiddle
        ///	112	Shanai
        ///	113	Tinkle_Bell
        ///	114	Agogo
        ///	115	Steel_Drums
        ///	116	Woodblock
        ///	117	Taiko_Drum
        ///	118	Melodic_Tom
        ///	119	Synth_Drum
        ///	120	Reverse_Cymbal
        ///	121	Guitar_Fret_Noise
        ///	122	Breath_Noise
        ///	123	Seashore
        ///	124	Bird_Tweet
        ///	125	Telephone_Ring
        ///	126	Helicopter
        ///	127	Applause
        ///	128	Gunshot
        /// </summary>
        public static Primitive Instrument
        {
            get { return _instrument[_channel] + 1; }
            set { _instrument[_channel] = value - 1; }
        }

        /// <summary>
        /// Set the key velocity (1 to 128).
        /// This is how hard a key was pressed (default 100).
        /// </summary>
        public static Primitive Velocity
        {
            get { return _velocity[_channel] + 1; }
            set { _velocity[_channel] = value - 1; }
        }

        /// <summary>
        /// Set the key volume (0 to 100, default 50).
        /// </summary>
        public static Primitive Volume
        {
            get { return _volume[_channel]; }
            set { _volume[_channel] = value; }
        }

        /// <summary>
        /// Set the key pan balance left (-100) or right (100) (default 0).
        /// </summary>
        public static Primitive Pan
        {
            get { return _pan[_channel]; }
            set { _pan[_channel] = value; }
        }

        /// <summary>
        /// Set the MIDI channel (1 to 16, default 1).
        /// Used by PlayMusic, Instrument, Velocity, Volume and Pan.
        /// </summary>
        public static Primitive Channel
        {
            get { return _channel + 1; }
            set { _channel = System.Math.Min(NUMCHANNEL - 1, System.Math.Max(0, value - 1)); }
        }

        /// <summary>
        /// Play an individual note (allows multi-channel instruments).
        /// </summary>
        /// <param name="octave">The octave (0 to 8).</param>
        /// <param name="note">The note ("A","F#","B-" etc).</param>
        /// <param name="channel">The MIDI channel (1 to 16).</param>
        /// <returns>The note value being played.</returns>
        public static Primitive PlayNote(Primitive octave, Primitive note, Primitive channel)
        {
            EnsureDeviceInit();
            channel = System.Math.Min(NUMCHANNEL - 1, System.Math.Max(0, channel - 1));
            ChangeInstrument(_instrument[channel], channel);
            ChangeVolume(_volume[channel], channel);
            ChangePan(_pan[channel], channel);
            _octave[channel] = System.Math.Min(8, System.Math.Max(0, octave));
            int value;
            if (!_notes.TryGetValue(note, out value)) value = 0;
            value += octave * 12;
            PlayNote(value, channel);
            return value + 1000 * channel;
        }

        /// <summary>
        /// Stop a note being played.
        /// </summary>
        /// <param name="value">The note to stop (this is the value returned by PlayNote when the note was started).</param>
        public static void EndNote(Primitive value)
        {
            EnsureDeviceInit();
            int channel = value / 1000;
            value -= 1000 * channel;
            StopNote(value, channel);
        }

        /// <summary>
        /// Reset (stop all music on all channels).
        /// </summary>
        public static void Reset()
        {
            ResetDevice();
        }

        /// <summary>
        /// Get an instrument name from its number.
        /// </summary>
        /// <param name="instrument">The instrument number.</param>
        /// <returns></returns>
        public static Primitive InstrumentName(Primitive instrument)
        {
            switch ((int)instrument)
            {
                case 1: return "Acoustic_Grand_Piano";
                case 2: return "Bright_Acoustic_Piano";
                case 3: return "Electric_Grand_Piano";
                case 4: return "Honky_tonk_Piano";
                case 5: return "Electric_Piano_1";
                case 6: return "Electric_Piano_2";
                case 7: return "Harpsichord";
                case 8: return "Clavi";
                case 9: return "Celesta";
                case 10: return "Glockenspiel";
                case 11: return "Music_Box";
                case 12: return "Vibraphone";
                case 13: return "Marimba";
                case 14: return "Xylophone";
                case 15: return "Tubular_Bells";
                case 16: return "Dulcimer";
                case 17: return "Drawbar_Organ";
                case 18: return "Percussive_Organ";
                case 19: return "Rock_Organ";
                case 20: return "Church_Organ";
                case 21: return "Reed_Organ";
                case 22: return "Accordion";
                case 23: return "Harmonica";
                case 24: return "Tango_Accordion";
                case 25: return "Acoustic_Guitar_nylon";
                case 26: return "Acoustic_Guitar_steel";
                case 27: return "Electric_Guitar_jazz";
                case 28: return "Electric_Guitar_clean";
                case 29: return "Electric_Guitar_muted";
                case 30: return "Overdriven_Guitar";
                case 31: return "Distortion_Guitar";
                case 32: return "Guitar_harmonics";
                case 33: return "Acoustic_Bass";
                case 34: return "Electric_Bass_finger";
                case 35: return "Electric_Bass_pick";
                case 36: return "Fretless_Bass";
                case 37: return "Slap_Bass_1";
                case 38: return "Slap_Bass_2";
                case 39: return "Synth_Bass_1";
                case 40: return "Synth_Bass_2";
                case 41: return "Violin";
                case 42: return "Viola";
                case 43: return "Cello";
                case 44: return "Contrabass";
                case 45: return "Tremolo_Strings";
                case 46: return "Pizzicato_Strings";
                case 47: return "Orchestral_Harp";
                case 48: return "Timpani";
                case 49: return "String_Ensemble_1";
                case 50: return "String_Ensemble_2";
                case 51: return "SynthStrings_1";
                case 52: return "SynthStrings_2";
                case 53: return "Choir_Aahs";
                case 54: return "Voice_Oohs";
                case 55: return "Synth_Voice";
                case 56: return "Orchestra_Hit";
                case 57: return "Trumpet";
                case 58: return "Trombone";
                case 59: return "Tuba";
                case 60: return "Muted_Trumpet";
                case 61: return "French_Horn";
                case 62: return "Brass_Section";
                case 63: return "SynthBrass_1";
                case 64: return "SynthBrass_2";
                case 65: return "Soprano_Sax";
                case 66: return "Alto_Sax";
                case 67: return "Tenor_Sax";
                case 68: return "Baritone_Sax";
                case 69: return "Oboe";
                case 70: return "English_Horn";
                case 71: return "Bassoon";
                case 72: return "Clarinet";
                case 73: return "Piccolo";
                case 74: return "Flute";
                case 75: return "Recorder";
                case 76: return "Pan_Flute";
                case 77: return "Blown_Bottle";
                case 78: return "Shakuhachi";
                case 79: return "Whistle";
                case 80: return "Ocarina";
                case 81: return "Lead_1_square";
                case 82: return "Lead_2_sawtooth";
                case 83: return "Lead_3_calliope";
                case 84: return "Lead_4_chiff";
                case 85: return "Lead_5_charang";
                case 86: return "Lead_6_voice";
                case 87: return "Lead_7_fifths";
                case 88: return "Lead_8_bass_lead";
                case 89: return "Pad_1_new_age";
                case 90: return "Pad_2_warm";
                case 91: return "Pad_3_polysynth";
                case 92: return "Pad_4_choir";
                case 93: return "Pad_5_bowed";
                case 94: return "Pad_6_metallic";
                case 95: return "Pad_7_halo";
                case 96: return "Pad_8_sweep";
                case 97: return "FX_1_rain";
                case 98: return "FX_2_soundtrack";
                case 99: return "FX_3_crystal";
                case 100: return "FX_4_atmosphere";
                case 101: return "FX_5_brightness";
                case 102: return "FX_6_goblins";
                case 103: return "FX_7_echoes";
                case 104: return "FX_8_sci_fi";
                case 105: return "Sitar";
                case 106: return "Banjo";
                case 107: return "Shamisen";
                case 108: return "Koto";
                case 109: return "Kalimba";
                case 110: return "Bag_pipe";
                case 111: return "Fiddle";
                case 112: return "Shanai";
                case 113: return "Tinkle_Bell";
                case 114: return "Agogo";
                case 115: return "Steel_Drums";
                case 116: return "Woodblock";
                case 117: return "Taiko_Drum";
                case 118: return "Melodic_Tom";
                case 119: return "Synth_Drum";
                case 120: return "Reverse_Cymbal";
                case 121: return "Guitar_Fret_Noise";
                case 122: return "Breath_Noise";
                case 123: return "Seashore";
                case 124: return "Bird_Tweet";
                case 125: return "Telephone_Ring";
                case 126: return "Helicopter";
                case 127: return "Applause";
                case 128: return "Gunshot";
                default: return "";
            }
        }

        public static Primitive Acoustic_Grand_Piano { get { return 1; } }
        public static Primitive Bright_Acoustic_Piano { get { return 2; } }
        public static Primitive Electric_Grand_Piano { get { return 3; } }
        public static Primitive Honky_tonk_Piano { get { return 4; } }
        public static Primitive Electric_Piano_1 { get { return 5; } }
        public static Primitive Electric_Piano_2 { get { return 6; } }
        public static Primitive Harpsichord { get { return 7; } }
        public static Primitive Clavi { get { return 8; } }
        public static Primitive Celesta { get { return 9; } }
        public static Primitive Glockenspiel { get { return 10; } }
        public static Primitive Music_Box { get { return 11; } }
        public static Primitive Vibraphone { get { return 12; } }
        public static Primitive Marimba { get { return 13; } }
        public static Primitive Xylophone { get { return 14; } }
        public static Primitive Tubular_Bells { get { return 15; } }
        public static Primitive Dulcimer { get { return 16; } }
        public static Primitive Drawbar_Organ { get { return 17; } }
        public static Primitive Percussive_Organ { get { return 18; } }
        public static Primitive Rock_Organ { get { return 19; } }
        public static Primitive Church_Organ { get { return 20; } }
        public static Primitive Reed_Organ { get { return 21; } }
        public static Primitive Accordion { get { return 22; } }
        public static Primitive Harmonica { get { return 23; } }
        public static Primitive Tango_Accordion { get { return 24; } }
        public static Primitive Acoustic_Guitar_nylon { get { return 25; } }
        public static Primitive Acoustic_Guitar_steel { get { return 26; } }
        public static Primitive Electric_Guitar_jazz { get { return 27; } }
        public static Primitive Electric_Guitar_clean { get { return 28; } }
        public static Primitive Electric_Guitar_muted { get { return 29; } }
        public static Primitive Overdriven_Guitar { get { return 30; } }
        public static Primitive Distortion_Guitar { get { return 31; } }
        public static Primitive Guitar_harmonics { get { return 32; } }
        public static Primitive Acoustic_Bass { get { return 33; } }
        public static Primitive Electric_Bass_finger { get { return 34; } }
        public static Primitive Electric_Bass_pick { get { return 35; } }
        public static Primitive Fretless_Bass { get { return 36; } }
        public static Primitive Slap_Bass_1 { get { return 37; } }
        public static Primitive Slap_Bass_2 { get { return 38; } }
        public static Primitive Synth_Bass_1 { get { return 39; } }
        public static Primitive Synth_Bass_2 { get { return 40; } }
        public static Primitive Violin { get { return 41; } }
        public static Primitive Viola { get { return 42; } }
        public static Primitive Cello { get { return 43; } }
        public static Primitive Contrabass { get { return 44; } }
        public static Primitive Tremolo_Strings { get { return 45; } }
        public static Primitive Pizzicato_Strings { get { return 46; } }
        public static Primitive Orchestral_Harp { get { return 47; } }
        public static Primitive Timpani { get { return 48; } }
        public static Primitive String_Ensemble_1 { get { return 49; } }
        public static Primitive String_Ensemble_2 { get { return 50; } }
        public static Primitive SynthStrings_1 { get { return 51; } }
        public static Primitive SynthStrings_2 { get { return 52; } }
        public static Primitive Choir_Aahs { get { return 53; } }
        public static Primitive Voice_Oohs { get { return 54; } }
        public static Primitive Synth_Voice { get { return 55; } }
        public static Primitive Orchestra_Hit { get { return 56; } }
        public static Primitive Trumpet { get { return 57; } }
        public static Primitive Trombone { get { return 58; } }
        public static Primitive Tuba { get { return 59; } }
        public static Primitive Muted_Trumpet { get { return 60; } }
        public static Primitive French_Horn { get { return 61; } }
        public static Primitive Brass_Section { get { return 62; } }
        public static Primitive SynthBrass_1 { get { return 63; } }
        public static Primitive SynthBrass_2 { get { return 64; } }
        public static Primitive Soprano_Sax { get { return 65; } }
        public static Primitive Alto_Sax { get { return 66; } }
        public static Primitive Tenor_Sax { get { return 67; } }
        public static Primitive Baritone_Sax { get { return 68; } }
        public static Primitive Oboe { get { return 69; } }
        public static Primitive English_Horn { get { return 70; } }
        public static Primitive Bassoon { get { return 71; } }
        public static Primitive Clarinet { get { return 72; } }
        public static Primitive Piccolo { get { return 73; } }
        public static Primitive Flute { get { return 74; } }
        public static Primitive Recorder { get { return 75; } }
        public static Primitive Pan_Flute { get { return 76; } }
        public static Primitive Blown_Bottle { get { return 77; } }
        public static Primitive Shakuhachi { get { return 78; } }
        public static Primitive Whistle { get { return 79; } }
        public static Primitive Ocarina { get { return 80; } }
        public static Primitive Lead_1_square { get { return 81; } }
        public static Primitive Lead_2_sawtooth { get { return 82; } }
        public static Primitive Lead_3_calliope { get { return 83; } }
        public static Primitive Lead_4_chiff { get { return 84; } }
        public static Primitive Lead_5_charang { get { return 85; } }
        public static Primitive Lead_6_voice { get { return 86; } }
        public static Primitive Lead_7_fifths { get { return 87; } }
        public static Primitive Lead_8_bass_lead { get { return 88; } }
        public static Primitive Pad_1_new_age { get { return 89; } }
        public static Primitive Pad_2_warm { get { return 90; } }
        public static Primitive Pad_3_polysynth { get { return 91; } }
        public static Primitive Pad_4_choir { get { return 92; } }
        public static Primitive Pad_5_bowed { get { return 93; } }
        public static Primitive Pad_6_metallic { get { return 94; } }
        public static Primitive Pad_7_halo { get { return 95; } }
        public static Primitive Pad_8_sweep { get { return 96; } }
        public static Primitive FX_1_rain { get { return 97; } }
        public static Primitive FX_2_soundtrack { get { return 98; } }
        public static Primitive FX_3_crystal { get { return 99; } }
        public static Primitive FX_4_atmosphere { get { return 100; } }
        public static Primitive FX_5_brightness { get { return 101; } }
        public static Primitive FX_6_goblins { get { return 102; } }
        public static Primitive FX_7_echoes { get { return 103; } }
        public static Primitive FX_8_sci_fi { get { return 104; } }
        public static Primitive Sitar { get { return 105; } }
        public static Primitive Banjo { get { return 106; } }
        public static Primitive Shamisen { get { return 107; } }
        public static Primitive Koto { get { return 108; } }
        public static Primitive Kalimba { get { return 109; } }
        public static Primitive Bag_pipe { get { return 110; } }
        public static Primitive Fiddle { get { return 111; } }
        public static Primitive Shanai { get { return 112; } }
        public static Primitive Tinkle_Bell { get { return 113; } }
        public static Primitive Agogo { get { return 114; } }
        public static Primitive Steel_Drums { get { return 115; } }
        public static Primitive Woodblock { get { return 116; } }
        public static Primitive Taiko_Drum { get { return 117; } }
        public static Primitive Melodic_Tom { get { return 118; } }
        public static Primitive Synth_Drum { get { return 119; } }
        public static Primitive Reverse_Cymbal { get { return 120; } }
        public static Primitive Guitar_Fret_Noise { get { return 121; } }
        public static Primitive Breath_Noise { get { return 122; } }
        public static Primitive Seashore { get { return 123; } }
        public static Primitive Bird_Tweet { get { return 124; } }
        public static Primitive Telephone_Ring { get { return 125; } }
        public static Primitive Helicopter { get { return 126; } }
        public static Primitive Applause { get { return 127; } }
        public static Primitive Gunshot { get { return 128; } }
    }
}
