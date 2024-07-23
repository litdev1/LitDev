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

using System;
using System.Drawing;
using Media = System.Windows.Media;

namespace LitDev
{
    /// <summary>
    /// Gets the Standard SmallBasic colours and other colour utilities.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDColours
    {
        public static double[] HSL2RGB(double H, double S, double L)
        {
            while (H < 0.0) H += 360.0;
            while (H > 360.0) H -= 360.0;
            S = S < 0.0 ? 0.0 : S > 1.0 ? 1.0 : S;
            L = L < 0.0 ? 0.0 : L > 1.0 ? 1.0 : L;

            double C = (1.0 - System.Math.Abs(2.0 * L - 1.0)) * S;
            double H2 = H / 60.0;
            double X = C * (1.0 - System.Math.Abs(H2 % 2.0 - 1.0));

            double[] RGB;

            if (H2 >= 0.0 && H2 < 1.0) RGB = new double[] { C, X, 0 };
            else if (H2 >= 1.0 && H2 < 2.0) RGB = new double[] { X, C, 0 };
            else if (H2 >= 2.0 && H2 < 3.0) RGB = new double[] { 0, C, X };
            else if (H2 >= 3.0 && H2 < 4.0) RGB = new double[] { 0, X, C };
            else if (H2 >= 4.0 && H2 < 5.0) RGB = new double[] { X, 0, C };
            else if (H2 >= 5.0 && H2 < 6.0) RGB = new double[] { C, 0, X };
            else RGB = new double[] { 0, 0, 0 };

            double m = L - C / 2.0;
            for (int i = 0; i < 3; i++) RGB[i] += m;

            return RGB;
        }

        public static double[] RGB2HSL(double R, double G, double B)
        {
            R = R < 0.0 ? 0.0 : R > 255.0 ? 1.0 : R / 255.0;
            G = G < 0.0 ? 0.0 : G > 255.0 ? 1.0 : G / 255.0;
            B = B < 0.0 ? 0.0 : B > 255.0 ? 1.0 : B / 255.0;

            double M = System.Math.Max(R, System.Math.Max(G, B));
            double m = System.Math.Min(R, System.Math.Min(G, B));
            double C = M - m;

            double H = 0.0, S, L;

            if (C == 0) H = 0.0;
            else if (M == R) H = ((G - B) / C) % 6.0;
            else if (M == G) H = ((B - R) / C) + 2.0;
            else if (M == B) H = ((R - G) / C) + 4.0;
            H *= 60.0;
            while (H < 0.0) H += 360.0;
            while (H > 360.0) H -= 360.0;
            H = H % 360.0;
            L = (M + m) / 2.0;
            S = (C == 0 || L == 1) ? 0.0 : C / (1.0 - System.Math.Abs(2.0 * L - 1.0));

            return new double[] { H, S, L };
        }

        /// <summary>
        /// Convert a Hue, Saturation, Lightness (HSL) color to a Red, Green, Blue (RGB) colour used by SmallBasic.
        /// </summary>
        /// <param name="H">Hue (0 to 360).</param>
        /// <param name="S">Saturation (0 to 1).</param>
        /// <param name="L">Lightness (0 to 1).</param>
        /// <returns>An RGB colour</returns>
        public static Primitive HSLtoRGB(Primitive H, Primitive S, Primitive L)
        {
            try
            {
                double[] RGB = HSL2RGB(H, S, L);
                return ColorTranslator.ToHtml(Color.FromArgb((int)(255 * RGB[0] + 0.5), (int)(255 * RGB[1] + 0.5), (int)(255 * RGB[2] + 0.5))).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "#000000";
            }
        }

        /// <summary>
        /// Modify the opacity of a colour.
        /// </summary>
        /// <param name="colour">The colour to modify.</param>
        /// <param name="opacity">The opacity (0 to 255).</param>
        /// <returns>The modified colour.</returns>
        public static Primitive SetOpacity(Primitive colour, Primitive opacity)
        {
            try
            {
                opacity = opacity < 0 ? 0 : opacity > 255 ? 255 : (int)opacity;
                Media.Color col = (Media.Color)Media.ColorConverter.ConvertFromString(colour);
                col.A = Utilities.getByte((int)opacity);
                return col.ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return colour;
            }
        }

        /// <summary>
        /// Get the Red component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The red component (0 to 255).</returns>
        public static Primitive GetRed(Primitive colour)
        {
            try
            {
                return ((Media.Color)Media.ColorConverter.ConvertFromString(colour)).R;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Green component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The green component (0 to 255).</returns>
        public static Primitive GetGreen(Primitive colour)
        {
            try
            {
                return ((Media.Color)Media.ColorConverter.ConvertFromString(colour)).G;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Blue component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The blue component (0 to 255).</returns>
        public static Primitive GetBlue(Primitive colour)
        {
            try
            {
                return ((Media.Color)Media.ColorConverter.ConvertFromString(colour)).B;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Opacity component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The opacity component (0 to 255).</returns>
        public static Primitive GetOpacity(Primitive colour)
        {
            try
            {
                return ((Media.Color)Media.ColorConverter.ConvertFromString(colour)).A;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Hue component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The hue component (0 to 360).</returns>
        public static Primitive GetHue(Primitive colour)
        {
            try
            {
                return RGB2HSL(GetRed(colour), GetGreen(colour), GetBlue(colour))[0];
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Saturation component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The saturation component (0 to 1).</returns>
        public static Primitive GetSaturation(Primitive colour)
        {
            try
            {
                return RGB2HSL(GetRed(colour), GetGreen(colour), GetBlue(colour))[1];
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the Lightness component of a colour.
        /// </summary>
        /// <param name="colour">The colour to get the component from.</param>
        /// <returns>The lightness component (0 to 1).</returns>
        public static Primitive GetLightness(Primitive colour)
        {
            try
            {
                return RGB2HSL(GetRed(colour), GetGreen(colour), GetBlue(colour))[2];
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        [HideFromIntellisense]
        public static Primitive GetPixel(Primitive x, Primitive y)
        {
            return LDGraphicsWindow.GetPixel(x, y);
        }

        // Red Colors
		public static Primitive IndianRed {get{return "#CD5C5C";}}
		public static Primitive LightCoral {get{return "#F08080";}}
		public static Primitive Salmon {get{return "#FA8072";}}
		public static Primitive DarkSalmon {get{return "#E9967A";}}
		public static Primitive LightSalmon {get{return "#FFA07A";}}
		public static Primitive Crimson {get{return "#DC143C";}}
		public static Primitive Red {get{return "#FF0000";}}
		public static Primitive Firebrick {get{return "#B22222";}}
		public static Primitive DarkRed {get{return "#8B0000";}}
		// Pink Colors
		public static Primitive Pink {get{return "#FFC0CB";}}
		public static Primitive LightPink {get{return "#FFB6C1";}}
		public static Primitive HotPink {get{return "#FF69B4";}}
		public static Primitive DeepPink {get{return "#FF1493";}}
		public static Primitive MediumVioletRed {get{return "#C71585";}}
		public static Primitive PaleVioletRed {get{return "#DB7093";}}
		// Orange Colors
        public static Primitive Coral { get { return "#FF7F50"; } }
        public static Primitive Tomato { get { return "#FF6347"; } }
		public static Primitive OrangeRed {get{return "#FF4500";}}
		public static Primitive DarkOrange {get{return "#FF8C00";}}
		public static Primitive Orange {get{return "#FFA500";}}
		// Yellow Colors
		public static Primitive Gold {get{return "#FFD700";}}
		public static Primitive Yellow {get{return "#FFFF00";}}
		public static Primitive LightYellow {get{return "#FFFFE0";}}
		public static Primitive LemonChiffon {get{return "#FFFACD";}}
		public static Primitive LightGoldenrodYellow {get{return "#FAFAD2";}}
		public static Primitive PapayaWhip {get{return "#FFEFD5";}}
		public static Primitive Moccasin {get{return "#FFE4B5";}}
		public static Primitive PeachPuff {get{return "#FFDAB9";}}
		public static Primitive PaleGoldenrod {get{return "#EEE8AA";}}
		public static Primitive Khaki {get{return "#F0E68C";}}
		public static Primitive DarkKhaki {get{return "#BDB76B";}}
		// Purple Colors
		public static Primitive Lavender {get{return "#E6E6FA";}}
		public static Primitive Thistle {get{return "#D8BFD8";}}
		public static Primitive Plum {get{return "#DDA0DD";}}
		public static Primitive Violet {get{return "#EE82EE";}}
		public static Primitive Orchid {get{return "#DA70D6";}}
		public static Primitive Fuchsia {get{return "#FF00FF";}}
		public static Primitive Magenta {get{return "#FF00FF";}}
		public static Primitive MediumOrchid {get{return "#BA55D3";}}
		public static Primitive MediumPurple {get{return "#9370DB";}}
		public static Primitive BlueViolet {get{return "#8A2BE2";}}
		public static Primitive DarkViolet {get{return "#9400D3";}}
		public static Primitive DarkOrchid {get{return "#9932CC";}}
		public static Primitive DarkMagenta {get{return "#8B008B";}}
		public static Primitive Purple {get{return "#800080";}}
		public static Primitive Indigo {get{return "#4B0082";}}
		public static Primitive SlateBlue {get{return "#6A5ACD";}}
		public static Primitive DarkSlateBlue {get{return "#483D8B";}}
		// Green Colors
		public static Primitive GreenYellow {get{return "#ADFF2F";}}
		public static Primitive Chartreuse {get{return "#7FFF00";}}
		public static Primitive LawnGreen {get{return "#7CFC00";}}
		public static Primitive Lime {get{return "#00FF00";}}
		public static Primitive LimeGreen {get{return "#32CD32";}}
		public static Primitive PaleGreen {get{return "#98FB98";}}
		public static Primitive LightGreen {get{return "#90EE90";}}
		public static Primitive MediumSpringGreen {get{return "#00FA9A";}}
		public static Primitive SpringGreen {get{return "#00FF7F";}}
		public static Primitive MediumSeaGreen {get{return "#3CB371";}}
		public static Primitive SeaGreen {get{return "#2E8B57";}}
		public static Primitive ForestGreen {get{return "#228B22";}}
		public static Primitive Green {get{return "#008000";}}
		public static Primitive DarkGreen {get{return "#006400";}}
		public static Primitive YellowGreen {get{return "#9ACD32";}}
		public static Primitive OliveDrab {get{return "#6B8E23";}}
		public static Primitive Olive {get{return "#808000";}}
		public static Primitive DarkOliveGreen {get{return "#556B2F";}}
		public static Primitive MediumAquamarine {get{return "#66CDAA";}}
		public static Primitive DarkSeaGreen {get{return "#8FBC8F";}}
		public static Primitive LightSeaGreen {get{return "#20B2AA";}}
		public static Primitive DarkCyan {get{return "#008B8B";}}
		public static Primitive Teal {get{return "#008080";}}
		// Blue Colors
		public static Primitive Aqua {get{return "#00FFFF";}}
		public static Primitive Cyan {get{return "#00FFFF";}}
		public static Primitive LightCyan {get{return "#E0FFFF";}}
		public static Primitive PaleTurquoise {get{return "#AFEEEE";}}
		public static Primitive Aquamarine {get{return "#7FFFD4";}}
		public static Primitive Turquoise {get{return "#40E0D0";}}
		public static Primitive MediumTurquoise {get{return "#48D1CC";}}
		public static Primitive DarkTurquoise {get{return "#00CED1";}}
		public static Primitive CadetBlue {get{return "#5F9EA0";}}
		public static Primitive SteelBlue {get{return "#4682B4";}}
		public static Primitive LightSteelBlue {get{return "#B0C4DE";}}
		public static Primitive PowderBlue {get{return "#B0E0E6";}}
		public static Primitive LightBlue {get{return "#ADD8E6";}}
		public static Primitive SkyBlue {get{return "#87CEEB";}}
		public static Primitive LightSkyBlue {get{return "#87CEFA";}}
		public static Primitive DeepSkyBlue {get{return "#00BFFF";}}
		public static Primitive DodgerBlue {get{return "#1E90FF";}}
		public static Primitive CornflowerBlue {get{return "#6495ED";}}
		public static Primitive MediumSlateBlue {get{return "#7B68EE";}}
		public static Primitive RoyalBlue {get{return "#4169E1";}}
		public static Primitive Blue {get{return "#0000FF";}}
		public static Primitive MediumBlue {get{return "#0000CD";}}
		public static Primitive DarkBlue {get{return "#00008B";}}
		public static Primitive Navy {get{return "#000080";}}
		public static Primitive MidnightBlue {get{return "#191970";}}
		// Brown Colors
		public static Primitive Cornsilk {get{return "#FFF8DC";}}
		public static Primitive BlanchedAlmond {get{return "#FFEBCD";}}
		public static Primitive Bisque {get{return "#FFE4C4";}}
		public static Primitive NavajoWhite {get{return "#FFDEAD";}}
		public static Primitive Wheat {get{return "#F5DEB3";}}
		public static Primitive BurlyWood {get{return "#DEB887";}}
		public static Primitive Tan {get{return "#D2B48C";}}
		public static Primitive RosyBrown {get{return "#BC8F8F";}}
		public static Primitive SandyBrown {get{return "#F4A460";}}
		public static Primitive Goldenrod {get{return "#DAA520";}}
		public static Primitive DarkGoldenrod {get{return "#B8860B";}}
		public static Primitive Peru {get{return "#CD853F";}}
		public static Primitive Chocolate {get{return "#D2691E";}}
		public static Primitive SaddleBrown {get{return "#8B4513";}}
		public static Primitive Sienna {get{return "#A0522D";}}
		public static Primitive Brown {get{return "#A52A2A";}}
		public static Primitive Maroon {get{return "#800000";}}
		// White Colors
		public static Primitive White {get{return "#FFFFFF";}}
		public static Primitive Snow {get{return "#FFFAFA";}}
		public static Primitive Honeydew {get{return "#F0FFF0";}}
		public static Primitive MintCream {get{return "#F5FFFA";}}
		public static Primitive Azure {get{return "#F0FFFF";}}
		public static Primitive AliceBlue {get{return "#F0F8FF";}}
		public static Primitive GhostWhite {get{return "#F8F8FF";}}
		public static Primitive WhiteSmoke {get{return "#F5F5F5";}}
		public static Primitive SeaShell {get{return "#FFF5EE";}}
		public static Primitive Beige {get{return "#F5F5DC";}}
		public static Primitive OldLace {get{return "#FDF5E6";}}
		public static Primitive FloralWhite {get{return "#FFFAF0";}}
		public static Primitive Ivory {get{return "#FFFFF0";}}
		public static Primitive AntiqueWhite {get{return "#FAEBD7";}}
		public static Primitive Linen {get{return "#FAF0E6";}}
		public static Primitive LavenderBlush {get{return "#FFF0F5";}}
		public static Primitive MistyRose {get{return "#FFE4E1";}}
		// Gray Colors
		public static Primitive Gainsboro {get{return "#DCDCDC";}}
		public static Primitive LightGray {get{return "#D3D3D3";}}
		public static Primitive Silver {get{return "#C0C0C0";}}
		public static Primitive DarkGray {get{return "#A9A9A9";}}
		public static Primitive Gray {get{return "#808080";}}
		public static Primitive DimGray {get{return "#696969";}}
		public static Primitive LightSlateGray {get{return "#778899";}}
		public static Primitive SlateGray {get{return "#708090";}}
		public static Primitive DarkSlateGray {get{return "#2F4F4F";}}
        public static Primitive Black { get { return "#000000"; } }
        //Transparent
        public static Primitive Transparent { get { return "#00FFFFFF"; } }
    }
}
