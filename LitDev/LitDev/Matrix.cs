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

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace LitDev
{
    public class Matrix
    {
        public string name;
        public int number;
        public int rows;
        public int cols;
        public double[,] matrix;

        public Matrix(int _rows, int _cols, int _number)
        {
            rows = _rows;
            cols = _cols;
            number = _number;
            name = "Matrix" + number.ToString();
            matrix = new double[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0.0;
                }
            }
        }

        public void Reset()
        {
            name = "";
            matrix = null;
        }

        public string Inverse(Matrix inverse)
        {
            int dim = rows;
            if (dim != cols || dim != inverse.rows || dim != inverse.cols) return "FAILED";
            int i, j, k;
            double tolerance = 1.0e-20;
            double[,] matrixCopy = new double[dim, dim];
            double pivot, temp;
            int iPivot;

            for (i = 0; i < dim; i++)
            {
                for (j = 0; j < dim; j++)
                {
                    matrixCopy[i, j] = matrix[i, j];
                    inverse.matrix[i, j] = 0.0;
                }
                inverse.matrix[i, i] = 1.0;
            }

            for (i = 0; i < dim; i++)
            {
                // Max entry in column in row i and below
                pivot = 0.0;
                iPivot = i;
                for (j = i; j < dim; j++)
                {
                    if (System.Math.Abs(matrixCopy[j, i]) > System.Math.Abs(pivot))
                    {
                        pivot = matrixCopy[j, i];
                        iPivot = j;
                    }
                }
                if (System.Math.Abs(pivot) < tolerance) return "SINGULAR";
                //Swap iPivot and i rows - the pivot is now in [i,i]
                if (i != iPivot)
                {
                    for (j = 0; j < dim; j++)
                    {
                        temp = matrixCopy[i, j];
                        matrixCopy[i, j] = matrixCopy[iPivot, j];
                        matrixCopy[iPivot, j] = temp;
                        temp = inverse.matrix[i, j];
                        inverse.matrix[i, j] = inverse.matrix[iPivot, j];
                        inverse.matrix[iPivot, j] = temp;
                    }
                }
                //Divide row i by pivot - [i,i] is now 1
                for (j = 0; j < dim; j++)
                {
                    matrixCopy[i, j] /= pivot;
                    inverse.matrix[i, j] /= pivot;
                }
                //Subtract this row from rows below leaving zeros in Lower triangle
                for (j = i + 1; j < dim; j++)
                {
                    pivot = matrixCopy[j, i];
                    for (k = 0; k < dim; k++)
                    {
                        matrixCopy[j, k] -= pivot * matrixCopy[i, k];
                        inverse.matrix[j, k] -= pivot * inverse.matrix[i, k];
                    }
                }
            }
            //Back eliminate Upper triangle
            for (i = dim - 1; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    pivot = matrixCopy[j, i];
                    for (k = 0; k < dim; k++)
                    {
                        matrixCopy[j, k] -= pivot * matrixCopy[i, k];
                        inverse.matrix[j, k] -= pivot * inverse.matrix[i, k];
                    }
                }
            }
            return "";
        }

        public string Transpose(Matrix transpose)
        {
            if (rows != transpose.cols || cols != transpose.rows) return "FAILED";

            double[,] _transpose = new double[transpose.rows, transpose.cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    _transpose[j, i] = matrix[i, j];
                }
            }

            for (int i = 0; i < transpose.rows; i++)
            {
                for (int j = 0; j < transpose.cols; j++)
                {
                    transpose.matrix[i, j] = _transpose[i, j];
                }
            }
            return "";
        }

        public string Add(Matrix matrix2, Matrix result)
        {
            if (result.rows != rows || result.cols != cols) return "FAILED";
            if (matrix2.rows != rows || matrix2.cols != cols) return "FAILED";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.matrix[i, j] = matrix[i, j] + matrix2.matrix[i, j];
                }
            }
            return "";
        }

        public string Add(double scalar, Matrix result)
        {
            if (result.rows != rows || result.cols != cols) return "FAILED";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.matrix[i, j] = matrix[i, j] + scalar;
                }
            }
            return "";
        }

        public string Multiply(Matrix matrix2, Matrix result)
        {
            if (cols != matrix2.rows || rows != result.rows || matrix2.cols != result.cols) return "FAILED";
            double[,] _result = new double[result.rows, result.cols];
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.cols; j++)
                {
                    _result[i, j] = 0.0;
                    for (int k = 0; k < cols; k++)
                    {
                        _result[i, j] += matrix[i, k] * matrix2.matrix[k, j];
                    }
                }
            }
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.cols; j++)
                {
                    result.matrix[i, j] = _result[i, j];
                }
            }
            return "";
        }

        public string Multiply(double scalar, Matrix result)
        {
            if (result.rows != rows || result.cols != cols) return "FAILED";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.matrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return "";
        }

        public string Copy(Matrix matrix2)
        {
            if (rows != matrix2.rows || cols != matrix2.cols) return "FAILED";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2.matrix[i, j] = matrix[i, j];
                }
            }
            return "";
        }
    }

    /// <summary>
    /// A 2-Dimensional matrix structure that can be used to solve linear equations or other methods.
    /// An error will result in a return value "FAILED";
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDMatrix
    {
        private static List<Matrix> Matrices = new List<Matrix>();

        private static Matrix getMatrix(string name)
        {
            foreach (Matrix _matrix in Matrices)
            {
                if (_matrix.name == name) return _matrix;
            }
            return null;
        }

        private static int getNewNumber()
        {
            int i = 1;
            foreach (Matrix _matrix in Matrices)
            {
                if (i <= _matrix.number) i = _matrix.number + 1;
            }
            return i;
        }

        /// <summary>
        /// Create a matrix object.
        /// Row and column matrices can be defined with rows = 1 or cols = 1 respectively.
        /// </summary>
        /// <param name="rows">The number of rows.</param>
        /// <param name="cols">The number of columns.</param>
        /// <returns>The matrix or "FAILED".</returns>
        public static Primitive Create(Primitive rows, Primitive cols)
        {
            try
            {
                if (rows >= 1 && cols >= 1)
                {
                    Matrix _matrix = new Matrix(rows, cols, getNewNumber());
                    Matrices.Add(_matrix);
                    return _matrix.name;
                }
                else
                {
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Delete an existing matrix (not generally required, but can save memory if lots of matrices are created).
        /// </summary>
        /// <param name="matrix">
        /// The matrix name.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Delete(Primitive matrix)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                if (null == _matrix) return "FAILED";
                _matrix.Reset();
                Matrices.Remove(_matrix);
                return "";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Set value in matrix.
        /// </summary>
        /// <param name="matrix">
        /// The matrix name.
        /// </param>
        /// <param name="row">
        /// The row at which to add the value (indexed starting from 1).
        /// </param>
        /// <param name="col">
        /// The column at which to add the value (indexed starting from 1).
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive SetValue(Primitive matrix, Primitive row, Primitive col, Primitive value)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                if (null != _matrix && row >= 1 && row <= _matrix.rows && col >= 1 && col <= _matrix.cols)
                {
                    _matrix.matrix[row - 1, col - 1] = value;
                    return "";
                }
                else
                {
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get value in matrix.
        /// </summary>
        /// <param name="matrix">
        /// The matrix name.
        /// </param>
        /// <param name="row">
        /// The row at which to get the value (indexed starting from 1).
        /// </param>
        /// <param name="col">
        /// The column at which to get the value (indexed starting from 1).
        /// </param>
        /// <returns>
        /// The value or "FAILED".
        /// </returns>
        public static Primitive GetValue(Primitive matrix, Primitive row, Primitive col)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                if (null != _matrix && row >= 1 && row <= _matrix.rows && col >= 1 && col <= _matrix.cols)
                {
                    return _matrix.matrix[row - 1, col - 1];
                }
                return "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Copy one matrix to a new matrix.
        /// </summary>
        /// <param name="matrix">
        /// The matrix to copy.
        /// </param>
        /// <returns>
        /// A copy of the matrix or "FAILED".
        /// </returns>
        public static Primitive CopyNew(Primitive matrix)
        {
            try
            {
                Matrix _matrix1 = getMatrix(matrix);
                if (null == _matrix1) return "FAILED";
                Matrix _matrix2 = new Matrix(_matrix1.rows, _matrix1.cols, getNewNumber());
                Matrices.Add(_matrix2);

                return _matrix1.Copy(_matrix2) == "" ? _matrix2.name : "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Copy one matrix to an existing matrix.
        /// The dimensions of the 2 matrices must be the same.
        /// </summary>
        /// <param name="matrix1">
        /// The matrix to copy from.
        /// </param>
        /// <param name="matrix2">
        /// The matrix to copy to.
        /// </param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Copy(Primitive matrix1, Primitive matrix2)
        {
            try
            {
                Matrix _matrix1 = getMatrix(matrix1);
                Matrix _matrix2 = getMatrix(matrix2);
                if (null == _matrix1 || null == _matrix2) return "FAILED";

                return _matrix1.Copy(_matrix2);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Add two matrices, the number of rows and columns of the 3 matrices given must be the same.
        /// Alternatively, if the second matrix is a scalar number then it is added to each element of the first matrix.
        /// </summary>
        /// <param name="matrix1">The first matrix.</param>
        /// <param name="matrix2">The second matrix (or scalar value).</param>
        /// <param name="result">The result matrix.</param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Add(Primitive matrix1, Primitive matrix2, Primitive result)
        {
            try
            {
                Matrix _matrix1 = getMatrix(matrix1);
                Matrix _matrix2 = getMatrix(matrix2);
                Matrix _result = getMatrix(result);
                if (null == _matrix1 || null == _result) return "FAILED";
                if (null == _matrix2)
                {
                    double scalar = (double)matrix2;
                    return _matrix1.Add(scalar, _result);
                }
                else
                {
                    return _matrix1.Add(_matrix2, _result);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Multiply two matrices, the number of columns of the first and rows of the second matrix must be the same.
        /// The number of rows and columns of the result matrix must be the rows of the first and columns of the second.
        /// Alternatively, if the second matrix is a scalar number then it is multiplied by each element of the first matrix and the dimensions of the first and result must be the same.
        /// </summary>
        /// <param name="matrix1">The first matrix.</param>
        /// <param name="matrix2">The second matrix (or scalar value).</param>
        /// <param name="result">The result matrix.</param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Multiply(Primitive matrix1, Primitive matrix2, Primitive result)
        {
            try
            {
                Matrix _matrix1 = getMatrix(matrix1);
                Matrix _matrix2 = getMatrix(matrix2);
                Matrix _result = getMatrix(result);
                if (null == _matrix1 || null == _result) return "FAILED";
                if (null == _matrix2)
                {
                    double scalar = (double)matrix2;
                    return _matrix1.Multiply(scalar, _result);
                }
                else
                {
                    return _matrix1.Multiply(_matrix2, _result);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Calculate the inverse of a matrix (using Gaussian Elimination).
        /// The number of rows and columns of the matrix and inverse must be the same (square matrices).
        /// A singular matrix returns "SINGULAR" and the inverse matrix will be incorrect.
        /// </summary>
        /// <param name="matrix">The matrix to invert (unmodified by inversion).</param>
        /// <param name="inverse">The inverse matrix.</param>
        /// <returns>
        /// "FAILED" or "SINGULAR" or "" for success.
        /// </returns>
        public static Primitive Inverse(Primitive matrix, Primitive inverse)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                Matrix _inverse = getMatrix(inverse);
                if (null == _matrix || null == _inverse) return "FAILED";

                return _matrix.Inverse(_inverse);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Calculate the transpose of a matrix.
        /// The number of rows and columns of the matrix and transpose must be reversed (cols = rows and vice versa).
        /// </summary>
        /// <param name="matrix">The matrix to transpose.</param>
        /// <param name="transpose">The resulting transposed matrix.</param>
        /// <returns>
        /// "FAILED" or "" for success.
        /// </returns>
        public static Primitive Transpose(Primitive matrix, Primitive transpose)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                Matrix _transpose = getMatrix(transpose);
                if (null == _matrix || null == _transpose) return "FAILED";

                return _matrix.Transpose(_transpose);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// View a matrix for dubugging purposes.
        /// </summary>
        /// <param name="matrix">The matrix to display.</param>
        /// <param name="modal">The matrix display will pause all other actions until it is closed. ("True" or "False").</param>
        /// <returns>
        /// None.
        /// </returns>
        public static void View(Primitive matrix, Primitive modal)
        {
            try
            {
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        Matrix _matrix = getMatrix(matrix);
                        if (null == _matrix) return;
                        FormMatrix _form = new FormMatrix(_matrix);
                        _form.TopMost = true;
                        if (modal)
                        {
                            _form.ShowDialog(Utilities.ForegroundHandle());
                        }
                        else
                        {
                            _form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Copy LDMatrix type to SmallBasic array type.
        /// 
        /// The reverse operation (SmallBasic to LDMatrix) isn't possible becuase the SmallBasic indexes are not necessarily contiguous integers.
        /// </summary>
        /// <param name="matrix">
        /// The matrix name.
        /// </param>
        /// <returns>
        /// The SmallBasic array or "FAILED".
        /// </returns>
        public static Primitive CopyToSBArray(Primitive matrix)
        {
            try
            {
                Matrix _matrix = getMatrix(matrix);
                if (null == _matrix) return "FAILED";
                string _SBarray = "";
                for (int i = 0; i < _matrix.rows; i++)
                {
                    _SBarray += (i + 1).ToString() + "=";
                    for (int j = 0; j < _matrix.cols; j++)
                    {
                        _SBarray += (j + 1).ToString() + "\\=" + _matrix.matrix[i, j].ToString(CultureInfo.InvariantCulture) + "\\;"; // Faster than Primitive _SBarray[i][j] = _matrix.matrix[i, j]
                    }
                    _SBarray += ";";
                }
                return Utilities.CreateArrayMap(_SBarray);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
