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
using SlimDX.DirectInput;
using System.Windows;
using Microsoft.SmallBasic.Library;

namespace LitDev.Engines
{
    class CheckForSlimDX
    {
        public bool Valid = false;
        public CheckForSlimDX()
        {
            DirectInput directInput = new DirectInput();
            Valid = (null != directInput);
        }
    }

    class VerifySlimDX
    {
        public static bool Verify(string objName)
        {
            try
            {
                return new CheckForSlimDX().Valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("This extension object (" + objName + ") requires SlimDX runtime for .Net 4.0 to be installed.\n\nIt can be downloaded from http://slimdx.org/download.php.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Program.End();
            }
            return false;
        }
    }
}
