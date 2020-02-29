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
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml;

namespace LitDev.Themes
{
    public static class Styles
    {
        private static ResourceDictionary resourceDictionary = null;
        private static Dictionary<string, string> styles = new Dictionary<string, string>();
        private static Style style;

        public static void Initialise(string key)
        {
            if (null == resourceDictionary)
            {
                Uri uri = new Uri("LitDev;component/Themes/Generic.xaml", UriKind.Relative);
                resourceDictionary = (ResourceDictionary)Application.LoadComponent(uri);
            }

            string value = "";
            if (!styles.TryGetValue(key, out value))
            {
                Style templateStyle = (Style)resourceDictionary[key];

                StringBuilder sb = new StringBuilder();
                XmlWriter writer = XmlWriter.Create(sb);
                XamlDesignerSerializationManager mgr = new XamlDesignerSerializationManager(writer);
                mgr.XamlWriterMode = XamlWriterMode.Expression;
                XamlWriter.Save(templateStyle, mgr);

                value = sb.ToString();
                styles[key] = value;
            }
            style = (Style)XamlReader.Parse(value);
        }

        public static void SetStyle(Button button, Brush unpressedBrush, Brush mouseOverBrush, Brush pressedBrush, Brush unpressedPen, Brush mouseOverPen, Brush pressedPen, double radius, bool bShine)
        {
            Initialise("Button1");

            ControlTemplate template = null;
            foreach (Setter setter in style.Setters)
            {
                if (setter.Property == Button.TemplateProperty)
                {
                    template = (ControlTemplate)setter.Value;
                    foreach (Trigger trigger in template.Triggers)
                    {
                        if (trigger.Property == Button.IsMouseOverProperty)
                        {
                            foreach (Setter setter1 in trigger.Setters)
                            {
                                if (setter1.TargetName == "buttonBackground")
                                {
                                    setter1.Value = mouseOverBrush;
                                }
                                else if (setter1.TargetName == "contentPresenter")
                                {
                                    setter1.Value = mouseOverPen;
                                }
                            }
                        }
                        else if (trigger.Property == Button.IsPressedProperty)
                        {
                            foreach (Setter setter1 in trigger.Setters)
                            {
                                if (setter1.TargetName == "buttonBackground")
                                {
                                    setter1.Value = pressedBrush;
                                }
                                else if (setter1.TargetName == "contentPresenter")
                                {
                                    setter1.Value = pressedPen;
                                }
                            }
                        }
                    }
                }
            }
            button.Width = button.ActualWidth;
            button.Height = button.ActualHeight;
            button.Background = unpressedBrush;
            button.Foreground = unpressedPen;
            button.FocusVisualStyle = null;
            button.Style = style;

            button.UpdateLayout();
            Rectangle rectangle = (Rectangle)button.Template.FindName("buttonBackground", button);
            rectangle.RadiusX = radius;
            rectangle.RadiusY = radius;
            rectangle = (Rectangle)button.Template.FindName("buttonShine", button);
            rectangle.Visibility = bShine ? Visibility.Visible : Visibility.Hidden;
            rectangle.RadiusX = radius * 0.67;
            rectangle.RadiusY = radius * 0.67;
        }
    }
}
