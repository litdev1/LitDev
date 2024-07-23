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
using System.Windows;
using System.Reflection;
using System.Windows.Media.Effects;
using Microsoft.Expression.Media.Effects;
using System.Windows.Media;
using LitDev.Engines;

namespace LitDev
{
    /// <summary>
    /// Apply visual effects to any shape or control.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDEffect
    {
        private enum eEffect { NONE, DROPSHADOW, BLUR, BLOOM, COLORTONE, EMBOSSED, MAGNIFY, MONOCHROME, PIXELATE, RIPPLE, SHARPEN, SWIRL };

        private static void ExtractDll()
        {
            try
            {
                string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Microsoft.Expression.Effects.dll";
                if (!System.IO.File.Exists(filename))
                {
                    Byte[] dll = global::LitDev.Properties.Resources.Microsoft_Expression_Effects;
                    using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                    {
                        fs.Write(dll, 0, dll.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private class Delegates
        {
            object[] data;

            public Delegates(object[] data)
            {
                this.data = data;
            }

            public void SetEffect_Delegate()
            {
                try
                {
                    int i = 0;
                    eEffect effect = (eEffect)data[i++];
                    Primitive properties = (Primitive)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    switch (effect)
                    {
                        case eEffect.NONE:
                            obj.Effect = null;
                            break;
                        case eEffect.DROPSHADOW:
                            obj.Effect = new DropShadowEffect();
                            if (SBArray.ContainsIndex(properties, "BlurRadius")) obj.Effect.SetValue(DropShadowEffect.BlurRadiusProperty, (double)properties["BlurRadius"]);
                            if (SBArray.ContainsIndex(properties, "Color")) obj.Effect.SetValue(DropShadowEffect.ColorProperty, (Color)ColorConverter.ConvertFromString(properties["Color"]));
                            if (SBArray.ContainsIndex(properties, "Direction")) obj.Effect.SetValue(DropShadowEffect.DirectionProperty, (double)properties["Direction"]);
                            if (SBArray.ContainsIndex(properties, "Opacity")) obj.Effect.SetValue(DropShadowEffect.OpacityProperty, (double)properties["Opacity"]);
                            if (SBArray.ContainsIndex(properties, "ShadowDepth")) obj.Effect.SetValue(DropShadowEffect.ShadowDepthProperty, (double)properties["ShadowDepth"]);
                            break;
                        case eEffect.BLUR:
                            obj.Effect = new BlurEffect();
                            if (SBArray.ContainsIndex(properties, "KernelType"))
                            {
                                string value = properties["KernelType"];
                                obj.Effect.SetValue(BlurEffect.KernelTypeProperty, value.ToLower() == "box" ? KernelType.Box : KernelType.Gaussian);
                            }
                            if (SBArray.ContainsIndex(properties, "Radius")) obj.Effect.SetValue(BlurEffect.RadiusProperty, (double)properties["Radius"]);
                            break;
                        case eEffect.BLOOM:
                            obj.Effect = new BloomEffect();
                            if (SBArray.ContainsIndex(properties, "BaseIntensity")) obj.Effect.SetValue(BloomEffect.BaseIntensityProperty, (double)properties["BaseIntensity"]);
                            if (SBArray.ContainsIndex(properties, "BaseSaturation")) obj.Effect.SetValue(BloomEffect.BaseSaturationProperty, (double)properties["BaseSaturation"]);
                            if (SBArray.ContainsIndex(properties, "BloomIntensity")) obj.Effect.SetValue(BloomEffect.BloomIntensityProperty, (double)properties["BloomIntensity"]);
                            if (SBArray.ContainsIndex(properties, "BloomSaturation")) obj.Effect.SetValue(BloomEffect.BloomSaturationProperty, (double)properties["BloomSaturation"]);
                            if (SBArray.ContainsIndex(properties, "Threshold")) obj.Effect.SetValue(BloomEffect.ThresholdProperty, (double)properties["Threshold"]);
                            break;
                        case eEffect.COLORTONE:
                            obj.Effect = new ColorToneEffect();
                            if (SBArray.ContainsIndex(properties, "DarkColor")) obj.Effect.SetValue(ColorToneEffect.DarkColorProperty, (Color)ColorConverter.ConvertFromString(properties["DarkColor"]));
                            if (SBArray.ContainsIndex(properties, "Desaturation")) obj.Effect.SetValue(ColorToneEffect.DesaturationProperty, (double)properties["Desaturation"]);
                            if (SBArray.ContainsIndex(properties, "LightColor")) obj.Effect.SetValue(ColorToneEffect.LightColorProperty, (Color)ColorConverter.ConvertFromString(properties["LightColor"]));
                            if (SBArray.ContainsIndex(properties, "ToneAmount")) obj.Effect.SetValue(ColorToneEffect.ToneAmountProperty, (double)properties["ToneAmount"]);
                            break;
                        case eEffect.EMBOSSED:
                            obj.Effect = new EmbossedEffect();
                            if (SBArray.ContainsIndex(properties, "Amount")) obj.Effect.SetValue(EmbossedEffect.AmountProperty, (double)properties["Amount"]);
                            if (SBArray.ContainsIndex(properties, "Color")) obj.Effect.SetValue(EmbossedEffect.ColorProperty, (Color)ColorConverter.ConvertFromString(properties["Color"]));
                            if (SBArray.ContainsIndex(properties, "Height")) obj.Effect.SetValue(EmbossedEffect.HeightProperty, (double)properties["Height"]);
                            break;
                        case eEffect.MAGNIFY:
                            obj.Effect = new MagnifyEffect();
                            if (SBArray.ContainsIndex(properties, "Amount")) obj.Effect.SetValue(MagnifyEffect.AmountProperty, (double)properties["Amount"]);
                            if (SBArray.ContainsIndex(properties, "Center"))
                            {
                                Primitive center = properties["Center"];
                                Point point = new Point(0.5, 0.5);
                                if (SBArray.GetItemCount(center) == 2)
                                {
                                    Primitive indices = SBArray.GetAllIndices(center);
                                    point.X = center[indices[1]];
                                    point.Y = center[indices[2]];
                                }
                                obj.Effect.SetValue(MagnifyEffect.CenterProperty, point);
                            }
                            if (SBArray.ContainsIndex(properties, "InnerRadius")) obj.Effect.SetValue(MagnifyEffect.InnerRadiusProperty, (double)properties["InnerRadius"]);
                            if (SBArray.ContainsIndex(properties, "OuterRadius")) obj.Effect.SetValue(MagnifyEffect.OuterRadiusProperty, (double)properties["OuterRadius"]);
                            break;
                        case eEffect.MONOCHROME:
                            obj.Effect = new MonochromeEffect();
                            if (SBArray.ContainsIndex(properties, "Color")) obj.Effect.SetValue(MonochromeEffect.ColorProperty, (Color)ColorConverter.ConvertFromString(properties["Color"]));
                            break;
                        case eEffect.PIXELATE:
                            obj.Effect = new PixelateEffect();
                            if (SBArray.ContainsIndex(properties, "Pixelation")) obj.Effect.SetValue(PixelateEffect.PixelationProperty, (double)properties["Pixelation"]);
                            break;
                        case eEffect.RIPPLE:
                            obj.Effect = new RippleEffect();
                            if (SBArray.ContainsIndex(properties, "Center"))
                            {
                                Primitive center = properties["Center"];
                                Point point = new Point(0.5, 0.5);
                                if (SBArray.GetItemCount(center) == 2)
                                {
                                    Primitive indices = SBArray.GetAllIndices(center);
                                    point.X = center[indices[1]];
                                    point.Y = center[indices[2]];
                                }
                                obj.Effect.SetValue(RippleEffect.CenterProperty, point);
                            }
                            if (SBArray.ContainsIndex(properties, "Frequency")) obj.Effect.SetValue(RippleEffect.FrequencyProperty, (double)properties["Frequency"]);
                            if (SBArray.ContainsIndex(properties, "Magnitude")) obj.Effect.SetValue(RippleEffect.MagnitudeProperty, (double)properties["Magnitude"]);
                            if (SBArray.ContainsIndex(properties, "Phase")) obj.Effect.SetValue(RippleEffect.PhaseProperty, (double)properties["Phase"]);
                            break;
                        case eEffect.SHARPEN:
                            obj.Effect = new SharpenEffect();
                            if (SBArray.ContainsIndex(properties, "Amount")) obj.Effect.SetValue(SharpenEffect.AmountProperty, (double)properties["Amount"]);
                            if (SBArray.ContainsIndex(properties, "Height")) obj.Effect.SetValue(SharpenEffect.HeightProperty, (double)properties["Height"]);
                            break;
                        case eEffect.SWIRL:
                            obj.Effect = new SwirlEffect();
                            if (SBArray.ContainsIndex(properties, "AngleFrequency")) obj.Effect.SetValue(SwirlEffect.AngleFrequencyProperty, (double)properties["AngleFrequency"]);
                            if (SBArray.ContainsIndex(properties, "Center"))
                            {
                                Primitive center = properties["Center"];
                                Point point = new Point(0.5, 0.5);
                                if (SBArray.GetItemCount(center) == 2)
                                {
                                    Primitive indices = SBArray.GetAllIndices(center);
                                    point.X = center[indices[1]];
                                    point.Y = center[indices[2]];
                                }
                                obj.Effect.SetValue(SwirlEffect.CenterProperty, point);
                            }
                            if (SBArray.ContainsIndex(properties, "TwistAmount")) obj.Effect.SetValue(SwirlEffect.TwistAmountProperty, (double)properties["TwistAmount"]);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }
        private static void SetEffect(string shapeName, eEffect effect, Primitive properties)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                ExtractDll();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { effect, properties, obj });
                    FastThread.BeginInvoke(delegates.SetEffect_Delegate);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Clear effects.
        /// </summary>
        /// <param name="shapeName">The shape to clear the effects from.</param>
        public static void Clear(Primitive shapeName)
        {
            SetEffect(shapeName, eEffect.NONE, "");
        }

        [HideFromIntellisense]
        public static void DropShaddow(Primitive shapeName, Primitive properties)
        {
            DropShadow(shapeName, properties);
        }

        /// <summary>
        /// Apply a drop shadow effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// BlurRadius (default 5)
        /// Color (default "Black")
        /// Direction (default 315)
        /// Opacity (default 1)
        /// ShadowDepth (default 5)
        /// </param>
        public static void DropShadow(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.DROPSHADOW, properties);
        }

        /// <summary>
        /// Apply a blur effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// KernelType (default "Gaussian" or "Box")
        /// Radius (default 5)
        /// </param>
        public static void Blur(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.BLUR, properties);
        }

        /// <summary>
        /// Apply a bloom effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// BaseIntensity (default 1)
        /// BaseSaturation (default 1)
        /// BloomIntensity (default 1.25)
        /// BloomSaturation (default 1)
        /// Threshold (default 0.25)
        /// </param>
        public static void Bloom(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.BLOOM, properties);
        }

        /// <summary>
        /// Apply a colour tone effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Desaturation (default 0.5)
        /// ToneAmount (default 0.5)
        /// LightColor (default "#FFE580")
        /// DarkColor (default "#338000")
        /// </param>
        public static void ColourTone(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.COLORTONE, properties);
        }

        /// <summary>
        /// Apply an embossed effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Amount (default 3)
        /// Color (default "Gray")
        /// Height (default 0.001)
        /// </param>
        public static void Embossed(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.EMBOSSED, properties);
        }

        /// <summary>
        /// Apply a magnify effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Amount (default 0.5)
        /// Center (default "X=0.5;Y=0.5;")
        /// InnerRadius (default 0.2)
        /// OuterRadius (default 0.4)
        /// </param>
        public static void Magnify(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.MAGNIFY, properties);
        }

        /// <summary>
        /// Apply a monochrome effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Color (default "White")
        /// </param>
        public static void Monochrome(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.MONOCHROME, properties);
        }

        /// <summary>
        /// Apply a pixelate effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Pixelation (default 0.75)
        /// </param>
        public static void Pixelate(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.PIXELATE, properties);
        }

        /// <summary>
        /// Apply a ripple effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Center (default "X=0.5;Y=0.5;")
        /// Frequency (default 40)
        /// Magnitude (default 0.1)
        /// Phase (default 10)
        /// </param>
        public static void Ripple(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.RIPPLE, properties);
        }

        /// <summary>
        /// Apply a sharpen effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// Amount (default 2)
        /// Height (default 0.0005)
        /// </param>
        public static void Sharpen(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.SHARPEN, properties);
        }

        /// <summary>
        /// Apply a swirl effect.
        /// </summary>
        /// <param name="shapeName">The shape to apply the effect to.</param>
        /// <param name="properties">An array of optional ("" for none) properties, indexed by the property name:
        /// AngleFrequency (default 45)
        /// Center (default "X=0.5;Y=0.5;")
        /// TwistAmount (default 10)
        /// </param>
        public static void Swirl(Primitive shapeName, Primitive properties)
        {
            SetEffect(shapeName, eEffect.SWIRL, properties);
        }
    }
}
