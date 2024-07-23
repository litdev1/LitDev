using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace LitDev
{
    public partial class FormMatrix : Form
    {
        public FormMatrix()
        {
            InitializeComponent();
        }

        private double[,] matrix;
        private int rows, cols;
        private string[,] value;
        private int[] maxLen;
        private int space = 2;
        private int rowLen;
        private int pos = -1;
        private static string sigFig = "";
        private static bool showSelection = true;

        public FormMatrix(Matrix _matrix)
        {
            InitializeComponent();

            rows = _matrix.rows;
            cols = _matrix.cols;
            Text = _matrix.name + " - Dimension " + rows.ToString() + "x" + cols.ToString();
            matrix = new double[rows, cols];
            value = new string[rows, cols];
            maxLen = new int[cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = _matrix.matrix[i, j];
                }
            }
            updateControls();
            setUp();
        }

        private void setUp()
        {
            int i, j;

            for (j = 0; j < cols; j++)
            {
                maxLen[j] = 0;
            }
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    value[i,j] = matrix[i, j].ToString("G"+sigFig, CultureInfo.InvariantCulture);
                    maxLen[j] = System.Math.Max(maxLen[j], value[i, j].Length);
                }
            }

            richTextBox1.Text = "";
            string padding;

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    padding = "";
                    if (matrix[i, j] < 0)
                    {
                        for (int k = 0; k < space + (maxLen[j] - value[i, j].Length); k++) padding += " ";
                        richTextBox1.Text += value[i, j] + padding;
                    }
                    else
                    {
                        for (int k = 0; k < space - 1 + (maxLen[j] - value[i, j].Length); k++) padding += " ";
                        richTextBox1.Text += " " + value[i, j] + padding;
                    }
                }
                richTextBox1.Text += "\r\n";
            }

            rowLen = 0;
            for (j = 0; j < cols; j++) rowLen += (space + maxLen[j]);
        }

        private void updateControls()
        {
            numericUpDown1.Value = sigFig == "" ? 0 : Utilities.getDecimal(sigFig);
            checkBox1.Checked = showSelection;
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int _pos = richTextBox1.GetCharIndexFromPosition(e.Location);
            if (_pos == pos) return;

            updateControls();
            pos = _pos;

            int posX = pos % (rowLen + 1);
            int posY = pos / (rowLen + 1);

            pos = posX;
            posX = 0;
            for (int j = 0; j < cols; j++)
            {
                if (pos >= space + maxLen[j])
                {
                    pos -= space + maxLen[j];
                    posX++;
                }
            }

            if (posX < cols && posY < rows)
            {
                if (showSelection)
                {
                    pos = posY * (rowLen + 1);
                    for (int j = 0; j < posX; j++) pos += space + maxLen[j];
                    richTextBox1.Select(pos, space + maxLen[posX]);
                    richTextBox1.Focus();
                }

                label1.Text = "(" + (posY + 1).ToString() + "," + (posX + 1).ToString() + ") = " + matrix[posY, posX];
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Decimal sig = ((NumericUpDown)sender).Value;
            sigFig = (sig > 0) ? sig.ToString() : "";

            setUp();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showSelection = ((CheckBox)sender).Checked;
        }
    }
}
