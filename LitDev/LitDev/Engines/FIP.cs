using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Numerics;

namespace LitDev
{
    public class FIP
    {

        /// <summary>
        /// Low pass filter
        /// </summary>
        /// <returns>Low pass filter</returns>
        public Double[,] LPF1()
        {
            return new Double[3, 3] { { 0.1111, 0.1111, 0.1111 }, { 0.1111, 0.1111, 0.1111 }, { 0.1111, 0.1111, 0.1111 }, };
        }

        /// <summary>
        /// Low pass filter
        /// </summary>
        /// <returns>Low pass filter</returns>
        public Double[,] LPF2()
        {
            return new Double[3, 3] { { 0.1, 0.1, 0.1 }, { 0.1, 0.2, 0.1 }, { 0.1, 0.1, 0.1 }, };
        }

        /// <summary>
        /// Low pass filter
        /// </summary>
        /// <returns>Low pass filter</returns>
        public Double[,] LPF3()
        {
            return new Double[3, 3] { { 0.0625, 0.125, 0.0625 }, { 0.125, 0.25, 0.125 }, { 0.0625, 0.125, 0.0625 }, };
        }

        /// <summary>
        /// Low pass filter
        /// </summary>
        /// <returns>Low pass filter</returns>
        public Double[,] LPF4()
        {
            return new Double[5, 5] {
            { 0.00366, 0.01465, 0.02564, 0.01465, 0.00366 },
            { 0.01465, 0.05861, 0.09524, 0.05861, 0.01465 },
            { 0.02564, 0.09524, 0.15018, 0.09524, 0.02564 },
            { 0.01465, 0.05861, 0.09524, 0.05861, 0.01465 },
            { 0.00366, 0.01465, 0.02564, 0.01465, 0.00366 }
            };
        }

        /// <summary>
        /// High pass filter
        /// </summary>
        /// <returns>High pass filter</returns>
        public int[,] HPF1()
        {
            return new int[3, 3] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 }, };
        }

        /// <summary>
        /// High pass filter
        /// </summary>
        /// <returns>High pass filter</returns>
        public int[,] HPF2()
        {
            return new int[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 }, };
        }

        /// <summary>
        /// High pass filter
        /// </summary>
        /// <returns>High pass filter</returns>
        public int[,] HPF3()
        {
            return new int[3, 3] { { 1, -2, 1 }, { -2, 5, -2 }, { 1, -2, 1 }, };
        }

        /// <summary>
        /// High pass filter
        /// </summary>
        /// <returns>High pass filter</returns>
        public int[,] HPF4()
        {
            return new int[5, 5] {
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, 25, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 }
            };
        }

        /// <summary>
        /// Laplace filter
        /// </summary>
        /// <returns>Laplace filter</returns>
        public int[,] LaplaceF1()
        {
            return new int[3, 3] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 }, };
        }

        /// <summary>
        /// Laplace filter
        /// </summary>
        /// <returns>Laplace filter</returns>
        public int[,] LaplaceF2()
        {
            return new int[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 }, };
        }

        /// <summary>
        /// Laplace filter
        /// </summary>
        /// <returns>Laplace filter</returns>
        public int[,] LaplaceF3()
        {
            return new int[3, 3] { { 1, -2, 1 }, { -2, 4, -2 }, { 1, -2, 1 }, };
        }

        /// <summary>
        /// Laplace filter
        /// </summary>
        /// <returns>Laplace filter</returns>
        public int[,] LaplaceF4()
        {
            return new int[5, 5] {
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, 24, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 }
            };
        }

        /// <summary>
        /// Gausian filter
        /// </summary>
        /// <returns>Gausian filter</returns>
        public Double[,] GF1()
        {
            return new Double[3, 3] { { 0.0625, 0.125, 0.0625 }, { 0.125, 0.25, 0.125 }, { 0.0625, 0.125, 0.0625 }, };
        }

        /// <summary>
        /// Gausian filter
        /// </summary>
        /// <returns>Gausian filter</returns>
        public Double[,] GF2()
        {
            return new Double[5, 5] {
            { 0.0192, 0.0192, 0.0385, 0.0192, 0.01921 },
            { 0.0192, 0.0385, 0.0769, 0.0385, 0.0192 },
            { 0.0385, 0.0769, 0.1538, 0.0769, 0.0385 },
            { 0.0192, 0.0385, 0.0769, 0.0385, 0.0192 },
            { 0.0192, 0.0192, 0.0385, 0.0192, 0.0192 }
            };
        }

        /// <summary>
        /// Gausian filter
        /// </summary>
        /// <returns>Gausian filter</returns>
        public Double[,] GF3()
        {
            return new Double[7, 7] {
            { 0.00714, 0.00714, 0.01429, 0.01429, 0.01429, 0.00714, 0.00714 },
            { 0.00714, 0.01429, 0.01429, 0.02857, 0.01429, 0.01429, 0.00714 },
            { 0.01429, 0.01429, 0.02857, 0.05714, 0.02857, 0.01429, 0.01429 },
            { 0.01429, 0.02857, 0.05714, 0.11429, 0.05714, 0.02857, 0.01429 },
            { 0.01429, 0.01429, 0.02857, 0.05714, 0.02857, 0.01429, 0.01429 },
            { 0.00714, 0.01429, 0.01429, 0.02857, 0.01429, 0.01429, 0.00714 },
            { 0.00714, 0.00714, 0.01429, 0.01429, 0.01429, 0.00714, 0.00714 }
            };
        }


        /// <summary>
        /// Image resize using nearest neighbour method
        /// </summary>
        /// <param name="OriginalImage">Original image</param>
        /// <param name="Width">Output width</param>
        /// <param name="Height">Output height</param>
        /// <returns>Resized image</returns>
        public Bitmap Resize(Bitmap OriginalImage, int Width, int Height)
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new Exception("Output image width and height must be positive");
            }

            Bitmap OutputImage = new System.Drawing.Bitmap(Width, Height);

            Double rh = Convert.ToDouble(OriginalImage.Width) / Convert.ToDouble(Width); // Horizontal ration
            Double rv = Convert.ToDouble(OriginalImage.Height) / Convert.ToDouble(Height); // Vertical ratio

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    int m = (int)(x * rh);
                    int n = (int)(y * rv);

                    if (m >= OriginalImage.Width) m = OriginalImage.Width - 1;
                    if (n >= OriginalImage.Height) n = OriginalImage.Height - 1;

                    Color pixel = OriginalImage.GetPixel(m, n);

                    OutputImage.SetPixel(x, y, pixel);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Image resize using bilinear interpolation method
        /// </summary>
        /// <param name="OriginalImage">Original image</param>
        /// <param name="Width">Output width</param>
        /// <param name="Height">Output height</param>
        /// <returns>Resized image</returns>
        public Bitmap Resize2(Bitmap OriginalImage, int Width, int Height)
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new Exception("Output image width and height must be positive");
            }


            Bitmap OutputImage = new System.Drawing.Bitmap(Width, Height);

            Double rh = Convert.ToDouble(OriginalImage.Width) / Convert.ToDouble(Width);
            Double rv = Convert.ToDouble(OriginalImage.Height) / Convert.ToDouble(Height);

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {

                    int m = (int)(x * rh);
                    int n = (int)(y * rv);

                    if (m >= OriginalImage.Width) m = OriginalImage.Width - 1;
                    if (n >= OriginalImage.Height) n = OriginalImage.Height - 1;

                    Double a = (x * rh) % m;
                    Double b = (y * rv) % n;

                    if (double.IsNaN(a))
                    {
                        a = 0;
                    }

                    if (double.IsNaN(b))
                    {
                        b = 0;
                    }

                    int m1 = m + 1;
                    int n1 = n + 1;

                    if (m1 >= OriginalImage.Width) m1 = m;
                    if (n1 >= OriginalImage.Height) n1 = n;

                    int red = 0, green = 0, blue = 0;

                    // horizontal
                    Color pixel00 = OriginalImage.GetPixel(m, n);
                    Color pixel10 = OriginalImage.GetPixel(m1, n);

                    // vertical
                    Color pixel01 = OriginalImage.GetPixel(m, n1);
                    Color pixel11 = OriginalImage.GetPixel(m1, n1);

                    // Red

                    Double Fa0R = (1 - a) * pixel00.R + a * pixel10.R;
                    Double Fa1R = (1 - a) * pixel01.R + a * pixel11.R;

                    Double FabR = (1 - b) * Fa0R + b * Fa1R;

                    red = (int)FabR;

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;

                    // Green
                    Double Fa0G = (1 - a) * pixel00.G + a * pixel10.G;
                    Double Fa1G = (1 - a) * pixel01.G + a * pixel11.G;

                    Double FabG = (1 - b) * Fa0G + b * Fa1G;

                    green = (int)FabG;

                    if (green > 255) green = 255;
                    if (green < 0) green = 0;

                    // Blue
                    Double Fa0B = (1 - a) * pixel00.B + a * pixel10.B;
                    Double Fa1B = (1 - a) * pixel01.B + a * pixel11.B;

                    Double FabB = (1 - b) * Fa0B + b * Fa1B;

                    blue = (int)FabB;

                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;


                    OutputImage.SetPixel(x, y, Color.FromArgb(255, red, green, blue));
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Image rotation
        /// </summary>
        /// <param name="OriginalImage">Original image</param>
        /// <param name="Angle">Rotate angle in degrees</param>
        /// <returns>Rotated image</returns>
        public Bitmap Rotate(Bitmap OriginalImage, Double Angle)
        {
            Angle = Angle % 360;

            Double x0 = (OriginalImage.Width / 2);
            Double y0 = (OriginalImage.Height / 2);
            Double Pi = Math.PI;

            Double AngleRad = Angle * Pi / 180;

            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);


            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {

                    int x1 = (int)(Math.Cos(AngleRad) * (x - x0) - Math.Sin(AngleRad) * (y - y0) + x0);
                    int y1 = (int)(Math.Sin(AngleRad) * (x - x0) + Math.Cos(AngleRad) * (y - y0) + y0);

                    Color pixel = new Color();

                    if (x1 < 0 || x1 >= OriginalImage.Width)
                    {

                    }
                    else if (y1 < 0 || y1 >= OriginalImage.Height)
                    {

                    }
                    else
                    {
                        pixel = OriginalImage.GetPixel(x1, y1);
                        OutputImage.SetPixel(x, y, pixel);
                    }

                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Image rotation
        /// </summary>
        /// <param name="OriginalImage">Original image</param>
        /// <param name="Angle">Rotate angle in degrees</param>
        /// <param name="xCenter">X Center</param>
        /// <param name="yCenter">Y Center</param>
        /// <returns>Rotated image</returns>
        public Bitmap Rotate(Bitmap OriginalImage, Double Angle, int xCenter, int yCenter)
        {
            Angle = Angle % 360;

            if (xCenter < 0 || xCenter > OriginalImage.Width || yCenter < 0 || yCenter > OriginalImage.Height)
            {
                throw new Exception("The center of rotation point must be in range of image dimensions");
            }


            Double x0 = Convert.ToDouble(xCenter);
            Double y0 = Convert.ToDouble(yCenter); ;

            Double Pi = Math.PI;

            Double AngleRad = Angle * Pi / 180;

            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);


            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {

                    int x1 = (int)(Math.Cos(AngleRad) * (x - x0) - Math.Sin(AngleRad) * (y - y0) + x0);
                    int y1 = (int)(Math.Sin(AngleRad) * (x - x0) + Math.Cos(AngleRad) * (y - y0) + y0);

                    Color pixel = new Color();

                    if (x1 < 0 || x1 >= OriginalImage.Width)
                    {

                    }
                    else if (y1 < 0 || y1 >= OriginalImage.Height)
                    {

                    }
                    else
                    {
                        pixel = OriginalImage.GetPixel(x1, y1);
                        OutputImage.SetPixel(x, y, pixel);
                    }

                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Transforms RGB color model to HSV
        /// </summary>
        /// <param name="pixel">RGB color</param>
        /// <returns>HSV values [H, S, V]</returns>
        public Double[] rgb2hsv(Color pixel)
        {
            Double[] hsv = new Double[3];

            Double cmin = Math.Min(Math.Min(pixel.R, pixel.G), pixel.B);
            Double cmax = Math.Max(Math.Max(pixel.R, pixel.G), pixel.B);
            Double delta = cmax - cmin;

            // Value component
            hsv[2] = (100 * cmax) / 255;

            // Saturation component
            if (cmax == 0)
            {
                hsv[1] = 0;
            }
            else
            {
                hsv[1] = delta / cmax;
            }

            // Hue component

            if (delta == 0)
            {
                hsv[0] = 0;
            }
            else if ((int)cmax == pixel.R)
            {
                hsv[0] = 60 * ((Convert.ToDouble(pixel.G - pixel.B) / delta) % 6);
            }
            else if ((int)cmax == pixel.G)
            {
                hsv[0] = 60 * ((Convert.ToDouble(pixel.B - pixel.R) / delta) + 2);
            }
            else
            {
                hsv[0] = 60 * ((Convert.ToDouble(pixel.R - pixel.G) / delta) + 4);
            }

            return hsv;
        }

        /// <summary>
        /// Transforms HSV color model to RGB
        /// </summary>
        /// <param name="hsv">HSV values [H, S, V]</param>
        /// <returns>RGB color</returns>
        public Color hsv2rgb(Double[] hsv)
        {
            Color pixel = new Color();

            Double T = (hsv[1] / 100) * (hsv[2] / 100); // C
            Double t = hsv[2] / 100 - T; // m
            Double q = T * (1 - Math.Abs((hsv[0] / 60) % 2 - 1));  // X

            Double Rp = 0, Gp = 0, Bp = 0;

            if (hsv[0] < 60)
            {
                Rp = T;
                Gp = q;
                Bp = 0;
            }
            else if (hsv[0] < 120)
            {
                Rp = q;
                Gp = T;
                Bp = 0;
            }
            else if (hsv[0] < 180)
            {
                Rp = 0;
                Gp = T;
                Bp = q;
            }
            else if (hsv[0] < 240)
            {
                Rp = 0;
                Gp = q;
                Bp = T;
            }
            else if (hsv[0] < 300)
            {
                Rp = q;
                Gp = 0;
                Bp = T;
            }
            else if (hsv[0] < 360)
            {
                Rp = T;
                Gp = 0;
                Bp = q;
            }

            int R = 0, G = 0, B = 0;

            R = (int)((Rp + t) * 255);
            G = (int)((Gp + t) * 255);
            B = (int)((Bp + t) * 255);

            if (R > 255) R = 255;
            if (R < 0) R = 0;

            if (G > 255) G = 255;
            if (G < 0) G = 0;

            if (B > 255) B = 255;
            if (B < 0) B = 0;

            pixel = Color.FromArgb(255, R, G, B);

            return pixel;
        }

        /// <summary>
        /// Transforms RGB color model to CMYK
        /// </summary>
        /// <param name="pixel">RGB color</param>
        /// <returns>CMYK values [C, M, Y, K]</returns>
        public Double[] rgb2cmyk(Color pixel)
        {
            Double nR = Convert.ToDouble(pixel.R) / 255;
            Double nG = Convert.ToDouble(pixel.G) / 255;
            Double nB = Convert.ToDouble(pixel.B) / 255;

            Double K = 1 - Math.Max(Math.Max(nR, nB), nG);
            Double C = (1 - nR - K) / (1 - K);
            Double M = (1 - nG - K) / (1 - K);
            Double Y = (1 - nB - K) / (1 - K);

            Double[] cmyk = new Double[4] { C, M, Y, K };

            return cmyk;
        }

        /// <summary>
        /// Transforms CMYK color model to RGB
        /// </summary>
        /// <param name="cmyk">CMYK values [C, M, Y, K]</param>
        /// <returns>RGB color</returns>
        public Color cmyk2rgb(Double[] cmyk)
        {
            Color pixel = new Color();

            Double r = 255 * (1 - cmyk[0]) * (1 - cmyk[3]);
            Double g = 255 * (1 - cmyk[1]) * (1 - cmyk[3]);
            Double b = 255 * (1 - cmyk[2]) * (1 - cmyk[3]);

            int R = (int)(r);
            int G = (int)(g);
            int B = (int)(b);

            if (R > 255) R = 255;
            if (R < 0) R = 0;

            if (G > 255) G = 255;
            if (G < 0) G = 0;

            if (B > 255) B = 255;
            if (B < 0) B = 0;

            pixel = Color.FromArgb(255, R, G, B);

            return pixel;
        }

        /// <summary>
        /// Converts RGB pixel to greyscale using luminance method
        /// </summary>
        /// <param name="pixel">RGB pixel</param>
        /// <returns>Greyscale pixel</returns>
        public Color color2greyscale(Color pixel)
        {
            int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
            Color newColor = Color.FromArgb(255, gs, gs, gs);

            return newColor;
        }

        /// <summary>
        /// Creates CMYK layesr from RGB image
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>CMYK layers as RGB bitmaps</returns>
        public Bitmap[] CMYKLayers(Bitmap OriginalImage)
        {
            Bitmap OutputImageC = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);
            Bitmap OutputImageM = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);
            Bitmap OutputImageY = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);
            Bitmap OutputImageK = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);

                    Double[] cmyk = rgb2cmyk(pixel);

                    Double C = cmyk[0];
                    Double M = cmyk[1];
                    Double Y = cmyk[2];
                    Double K = cmyk[3];

                    Color newColorC = cmyk2rgb(new Double[4] { C, 0, 0, 0 });
                    Color newColorM = cmyk2rgb(new Double[4] { 0, M, 0, 0 });
                    Color newColorY = cmyk2rgb(new Double[4] { 0, 0, Y, 0 });
                    Color newColorK = cmyk2rgb(new Double[4] { 0, 0, 0, K });

                    OutputImageC.SetPixel(x, y, newColorC);
                    OutputImageM.SetPixel(x, y, newColorM);
                    OutputImageY.SetPixel(x, y, newColorY);
                    OutputImageK.SetPixel(x, y, newColorK);
                }
            }

            Bitmap[] OutputImage = new Bitmap[4] { OutputImageC, OutputImageM, OutputImageY, OutputImageK };

            return OutputImage;
        }

        /// <summary>
        /// Transforms image into to shifted array of doubles 
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Shifted array</returns>
        private Double[,] Shift(Bitmap OriginalImage)
        {
            Double[,] proc = new Double[OriginalImage.Width, OriginalImage.Height];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    proc[i, j] = Math.Pow(-1, i + j) * Convert.ToDouble(OriginalImage.GetPixel(i, j).R);
                }
            }

            return proc;
        }

        /// <summary>
        /// Shifts array components
        /// </summary>
        /// <param name="Data">Original array</param>
        /// <returns>Shifted array</returns>
        private Double[,] Shift(Double[,] Data)
        {
            Double[,] proc = new Double[Data.GetLength(0), Data.GetLength(1)];

            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    proc[i, j] = Math.Pow(-1, i + j) * Data[i, j];
                }
            }

            return proc;
        }

        /// <summary>
        /// Discrete Fourier Transform of image
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Image spectrum</returns>
        public Complex[,] DFT(Bitmap OriginalImage)
        {
            Complex[,] fourier = new Complex[OriginalImage.Width, OriginalImage.Height];

            Bitmap image = this.ToGreyscale(OriginalImage);

            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            for (int k = 0; k < M; k++)
            {
                for (int l = 0; l < N; l++)
                {

                    Complex sum = 0;

                    for (int j = 0; j < N; j++)
                    {
                        for (int i = 0; i < M; i++)
                        {
                            Double p = Convert.ToDouble(image.GetPixel(i, j).R);

                            Complex im = new Complex(0, 1);

                            Double g = (k * i) / Convert.ToDouble(M) + (l * j) / Convert.ToDouble(N);

                            Complex exp = Complex.Exp(-im * 2 * Math.PI * g);

                            sum += p * exp;

                        }
                    }

                    fourier[k, l] = sum / Math.Sqrt(M * N);
                }
            }


            return fourier;
        }

        /// <summary>
        /// Shifted Discrete Fourier Transform of image.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Shifted image spectrum</returns>
        public Complex[,] SDFT(Bitmap OriginalImage)
        {
            Complex[,] fourier = new Complex[OriginalImage.Width, OriginalImage.Height];

            Bitmap image = this.ToGreyscale(OriginalImage);

            Double[,] mat = this.Shift(image);

            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            for (int k = 0; k < M; k++)
            {
                for (int l = 0; l < N; l++)
                {

                    Complex sum = 0;

                    for (int j = 0; j < N; j++)
                    {
                        for (int i = 0; i < M; i++)
                        {
                            Double p = mat[i, j];

                            Complex im = new Complex(0, 1);

                            Double g = (k * i) / Convert.ToDouble(M) + (l * j) / Convert.ToDouble(N);

                            Complex exp = Complex.Exp(-im * 2 * Math.PI * g);

                            sum += p * exp;

                        }
                    }

                    fourier[k, l] = sum / Math.Sqrt(M * N);
                }
            }


            return fourier;
        }

        /// <summary>
        /// Shifted Discrete Fourier Transform of two-dimensional signal
        /// </summary>
        /// <param name="Data">Two-dimensional signal</param>
        /// <returns>Shifted spectrum</returns>
        public Complex[,] SDFT(Double[,] Data)
        {
            Complex[,] fourier = new Complex[Data.GetLength(0), Data.GetLength(1)];

            //Bitmap image = this.ToGreyscale(OriginalImage);

            Data = this.Shift(Data);

            int M = Data.GetLength(0);
            int N = Data.GetLength(1);

            for (int k = 0; k < M; k++)
            {
                for (int l = 0; l < N; l++)
                {

                    //fourier[k, l] = new Complex(0, 0);

                    Complex sum = 0;

                    for (int j = 0; j < N; j++)
                    {
                        for (int i = 0; i < M; i++)
                        {
                            Double p = Data[i, j];

                            Complex im = new Complex(0, 1);

                            Double g = (k * i) / Convert.ToDouble(M) + (l * j) / Convert.ToDouble(N);

                            Complex exp = Complex.Exp(-im * 2 * Math.PI * g);

                            sum += p * exp;

                        }
                    }

                    fourier[k, l] = sum / Math.Sqrt(Convert.ToDouble(M) * Convert.ToDouble(N));


                }
            }


            return fourier;
        }

        /// <summary>
        /// Discrete Fourier Transform of two-dimensional signal
        /// </summary>
        /// <param name="Data">Two-dimensional signal</param>
        /// <returns>Spectrum</returns>
        public Complex[,] DFT(Double[,] Data)
        {
            Complex[,] fourier = new Complex[Data.GetLength(0), Data.GetLength(1)];

            //Bitmap image = this.ToGreyscale(OriginalImage);

            int M = Data.GetLength(0);
            int N = Data.GetLength(1);

            for (int k = 0; k < M; k++)
            {
                for (int l = 0; l < N; l++)
                {

                    //fourier[k, l] = new Complex(0, 0);

                    Complex sum = 0;

                    for (int j = 0; j < N; j++)
                    {
                        for (int i = 0; i < M; i++)
                        {
                            Double p = Data[i, j];

                            Complex im = new Complex(0, 1);

                            Double g = (k * i) / Convert.ToDouble(M) + (l * j) / Convert.ToDouble(N);

                            Complex exp = Complex.Exp(-im * 2 * Math.PI * g);

                            sum += p * exp;

                        }
                    }

                    fourier[k, l] = sum / Math.Sqrt(Convert.ToDouble(M) * Convert.ToDouble(N));


                }
            }


            return fourier;
        }


        /// <summary>
        /// Inverse Discrete Fourier Transform
        /// </summary>
        /// <param name="Spectrum">Image spectrum</param>
        /// <returns>Image</returns>
        public Bitmap iDFT(Complex[,] Spectrum)
        {
            Bitmap img = new Bitmap(Spectrum.GetLength(0), Spectrum.GetLength(1));

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {

                    Double I = Convert.ToDouble(i);
                    Double J = Convert.ToDouble(j);

                    Complex im = new Complex(0, 1);

                    Complex sum = 0;


                    for (int k = 0; k < Spectrum.GetLength(0); k++)
                    {
                        for (int l = 0; l < Spectrum.GetLength(1); l++)
                        {

                            Double K = Convert.ToDouble(k);
                            Double L = Convert.ToDouble(l);

                            Double G = (K * I) / Convert.ToDouble(Spectrum.GetLength(0)) + (L * J) / Convert.ToDouble(Spectrum.GetLength(1));

                            Complex exp = Complex.Exp(im * 2 * Math.PI * G);

                            sum += Spectrum[k, l] * exp;

                        }
                    }

                    int value = (int)(sum.Magnitude / Math.Sqrt(Convert.ToDouble(Spectrum.GetLength(0)) * Convert.ToDouble(Spectrum.GetLength(1))));

                    if (value > 255) value = 255;

                    img.SetPixel(i, j, Color.FromArgb(255, value, value, value));


                }
            }

            return img;
        }

        /// <summary>
        /// Inverse Discrete Fourier Transform
        /// </summary>
        /// <param name="Spectrum">Signal spectrum</param>
        /// <returns>Signal</returns>
        public Double[,] iDFT2(Complex[,] Spectrum)
        {
            Double[,] img = new Double[Spectrum.GetLength(0), Spectrum.GetLength(1)];

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {

                    Double I = Convert.ToDouble(i);
                    Double J = Convert.ToDouble(j);

                    Complex im = new Complex(0, 1);

                    Complex sum = 0;


                    for (int k = 0; k < Spectrum.GetLength(0); k++)
                    {
                        for (int l = 0; l < Spectrum.GetLength(1); l++)
                        {

                            Double K = Convert.ToDouble(k);
                            Double L = Convert.ToDouble(l);

                            Double G = (K * I) / Convert.ToDouble(Spectrum.GetLength(0)) + (L * J) / Convert.ToDouble(Spectrum.GetLength(1));

                            Complex exp = Complex.Exp(im * 2 * Math.PI * G);

                            sum += Spectrum[k, l] * exp;

                        }
                    }

                    //int value = (int)sum.Magnitude;

                    //if (value > 255) value = 255;

                    img[i, j] = sum.Magnitude / Math.Sqrt(Convert.ToDouble(Spectrum.GetLength(0)) * Convert.ToDouble(Spectrum.GetLength(1)));


                }
            }

            return img;
        }

        /// <summary>
        /// Inverse shifted Discrete Fourier Transform
        /// </summary>
        /// <param name="Spectrum">Signal spectrum</param>
        /// <returns>Signal</returns>
        public Double[,] iSDFT2(Complex[,] Spectrum)
        {
            Double[,] img = new Double[Spectrum.GetLength(0), Spectrum.GetLength(1)];

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {

                    Double I = Convert.ToDouble(i);
                    Double J = Convert.ToDouble(j);

                    Complex im = new Complex(0, 1);

                    Complex sum = 0;


                    for (int k = 0; k < Spectrum.GetLength(0); k++)
                    {
                        for (int l = 0; l < Spectrum.GetLength(1); l++)
                        {

                            Double K = Convert.ToDouble(k);
                            Double L = Convert.ToDouble(l);

                            Double G = (K * I) / Convert.ToDouble(Spectrum.GetLength(0)) + (L * J) / Convert.ToDouble(Spectrum.GetLength(1));

                            Complex exp = Complex.Exp(im * 2 * Math.PI * G);

                            sum += Spectrum[k, l] * exp;

                        }
                    }

                    //int value = (int)sum.Magnitude;

                    //if (value > 255) value = 255;

                    img[i, j] = sum.Magnitude / Math.Sqrt(Convert.ToDouble(Spectrum.GetLength(0)) * Convert.ToDouble(Spectrum.GetLength(1)));


                }
            }

            img = this.Shift(img);

            return img;
        }


        /// <summary>
        /// Inverse shifted Discrete Fourier Transform
        /// </summary>
        /// <param name="Spectrum">Image spectrum</param>
        /// <returns>Image</returns>
        public Bitmap iSDFT(Complex[,] Spectrum)
        {
            Double[,] img = new Double[Spectrum.GetLength(0), Spectrum.GetLength(1)];

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {

                    Double I = Convert.ToDouble(i);
                    Double J = Convert.ToDouble(j);

                    Complex im = new Complex(0, 1);

                    Complex sum = 0;


                    for (int k = 0; k < Spectrum.GetLength(0); k++)
                    {
                        for (int l = 0; l < Spectrum.GetLength(1); l++)
                        {

                            Double K = Convert.ToDouble(k);
                            Double L = Convert.ToDouble(l);

                            Double G = (K * I) / Convert.ToDouble(Spectrum.GetLength(0)) + (L * J) / Convert.ToDouble(Spectrum.GetLength(1));

                            Complex exp = Complex.Exp(im * 2 * Math.PI * G);

                            sum += Spectrum[k, l] * exp;

                        }
                    }

                    //int value = (int)sum.Magnitude;

                    //if (value > 255) value = 255;

                    img[i, j] = sum.Magnitude / Math.Sqrt(Convert.ToDouble(Spectrum.GetLength(0)) * Convert.ToDouble(Spectrum.GetLength(1)));


                }
            }

            //img = this.Shift(img);



            return this.Matrix2Image(img);
        }

        /// <summary>
        /// Converts array elements into pixel values (without normalization)
        /// </summary>
        /// <param name="Matrix">Array</param>
        /// <returns>Greyscale image</returns>
        public Bitmap Matrix2Image(Double[,] Matrix)
        {
            Bitmap img = new Bitmap(Matrix.GetLength(0), Matrix.GetLength(1));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    int value = (int)Matrix[i, j];

                    if (value > 255) value = 255;
                    if (value < 0) value = 0;

                    img.SetPixel(i, j, Color.FromArgb(255, value, value, value));

                }
            }

            return img;
        }

        /// <summary>
        /// Converts array elements into pixel values (without normalization)
        /// </summary>
        /// <param name="Matrix">Array</param>
        /// <returns>Greyscale image</returns>
        public Bitmap Matrix2Image(int[,] Matrix)
        {
            Bitmap img = new Bitmap(Matrix.GetLength(0), Matrix.GetLength(1));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    int value = (int)Matrix[i, j];

                    if (value > 255) value = 255;
                    if (value < 0) value = 0;

                    img.SetPixel(i, j, Color.FromArgb(255, value, value, value));

                }
            }

            return img;
        }

        /// <summary>
        /// Calculates array of magnitudes from array of complex elements
        /// </summary>
        /// <param name="Spectrum">Complex values array</param>
        /// <returns>Magnitudes values array</returns>
        public Double[,] Magnitude(Complex[,] Spectrum)
        {
            Double[,] mag = new Double[Spectrum.GetLength(0), Spectrum.GetLength(1)];

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {


                    mag[i, j] = Spectrum[i, j].Magnitude;
                }
            }


            return mag;
        }

        /// <summary>
        /// Calculates array of phases from array of complex elements
        /// </summary>
        /// <param name="Spectrum">Complex values array</param>
        /// <returns>Phases values array</returns>
        public Double[,] Phase(Complex[,] Spectrum)
        {
            Double[,] phase = new Double[Spectrum.GetLength(0), Spectrum.GetLength(1)];

            for (int i = 0; i < Spectrum.GetLength(0); i++)
            {
                for (int j = 0; j < Spectrum.GetLength(1); j++)
                {


                    phase[i, j] = Spectrum[i, j].Phase;
                }
            }


            return phase;
        }

        /// <summary>
        /// Converts array elements into pixel values (values normalized using 10-base logarithm)
        /// </summary>
        /// <param name="Matrix">Array</param>
        /// <returns>Greyscale image</returns>
        public Bitmap Matrix2ImageLog(Double[,] Matrix)
        {
            Bitmap img = new Bitmap(Matrix.GetLength(0), Matrix.GetLength(1));

            Double max = Matrix.Cast<Double>().Max();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {

                    Double a = 255 / Math.Log10(1 + max);

                    int value = (int)(a * Math.Log10(1 + Matrix[i, j]));

                    Color p = Color.FromArgb(255, value, value, value);

                    img.SetPixel(i, j, p);
                }
            }


            return img;

        }

        /// <summary>
        /// Converts array elements into pixel values (values normalized using maximum element)
        /// </summary>
        /// <param name="Matrix">Array</param>
        /// <returns>Greyscale image</returns>
        public Bitmap Matrix2ImageMax(Double[,] Matrix)
        {
            Bitmap img = new Bitmap(Matrix.GetLength(0), Matrix.GetLength(1));

            Double max = Matrix.Cast<Double>().Max();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {

                    //Double a = 255 / Math.Log10(1 + max);

                    //int value = (int)(a * Math.Log10(1 + Matrix[i, j]));

                    int value = (int)(Matrix[i, j] / max);

                    if (value > 255) value = 255;

                    Color p = Color.FromArgb(255, value, value, value);

                    img.SetPixel(i, j, p);
                }
            }


            return img;

        }

        /// <summary>
        /// Seperates values of each RGB layer
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>[Red, Green, Blue] image layers</returns>
        public int[,,] RGBMatrix(Bitmap OriginalImage)
        {
            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            int[,,] RGB = new int[3, M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Color p = OriginalImage.GetPixel(i, j);

                    RGB[0, i, j] = p.R;
                    RGB[1, i, j] = p.G;
                    RGB[2, i, j] = p.B;

                }
            }

            return RGB;
        }

        /// <summary>
        /// Separates red color layer
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Red color layer</returns>
        public int[,] RMatrix(Bitmap OriginalImage)
        {
            int[,,] rgb = this.RGBMatrix(OriginalImage);

            int[,] p = new int[OriginalImage.Width, OriginalImage.Height];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    p[i, j] = rgb[0, i, j];
                }
            }

            return p;
        }

        /// <summary>
        /// Separates green color layer
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Green color layer</returns>
        public int[,] GMatrix(Bitmap OriginalImage)
        {
            int[,,] rgb = this.RGBMatrix(OriginalImage);

            int[,] p = new int[OriginalImage.Width, OriginalImage.Height];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    p[i, j] = rgb[1, i, j];
                }
            }

            return p;
        }

        /// <summary>
        /// Separates blue color layer
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Blue color layer</returns>
        public int[,] BMatrix(Bitmap OriginalImage)
        {
            int[,,] rgb = this.RGBMatrix(OriginalImage);

            int[,] p = new int[OriginalImage.Width, OriginalImage.Height];

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    p[i, j] = rgb[2, i, j];
                }
            }

            return p;
        }

        /// <summary>
        /// Seperates values of each RGB layer
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>[Red, Green, Blue] image layers as Bitmaps</returns>
        public Bitmap[] RGBLayers(Bitmap OriginalImage)
        {
            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            Bitmap R = new Bitmap(M, N);
            Bitmap G = new Bitmap(M, N);
            Bitmap B = new Bitmap(M, N);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Color p = OriginalImage.GetPixel(i, j);

                    R.SetPixel(i, j, Color.FromArgb(255, p.R, 0, 0));
                    G.SetPixel(i, j, Color.FromArgb(255, 0, p.G, 0));
                    B.SetPixel(i, j, Color.FromArgb(255, 0, 0, p.B));

                }
            }

            Bitmap[] RGB = new Bitmap[3] { R, G, B };

            return RGB;
        }


        /// <summary>
        /// Image histogram normalization using 10-base logarithm scaling
        /// </summary>
        /// <param name="OriginalImage">Original AGB image</param>
        /// <returns>Normalized image</returns>
        public Bitmap LogaritmicScaling(Bitmap OriginalImage)
        {
            Bitmap img = new Bitmap(OriginalImage.Width, OriginalImage.Height);

            int[,] r = RMatrix(OriginalImage);
            int[,] g = GMatrix(OriginalImage);
            int[,] b = BMatrix(OriginalImage);

            Double maxR = Convert.ToDouble(r.Cast<int>().Max());
            Double maxG = Convert.ToDouble(g.Cast<int>().Max());
            Double maxB = Convert.ToDouble(b.Cast<int>().Max());

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                for (int j = 0; j < OriginalImage.Height; j++)
                {

                    Double aR = 255 / Math.Log10(1 + maxR);
                    int valueR = (int)(aR * Math.Log10(1 + OriginalImage.GetPixel(i, j).R));

                    Double aG = 255 / Math.Log10(1 + maxG);
                    int valueG = (int)(aG * Math.Log10(1 + OriginalImage.GetPixel(i, j).G));

                    Double aB = 255 / Math.Log10(1 + maxB);
                    int valueB = (int)(aB * Math.Log10(1 + OriginalImage.GetPixel(i, j).B));

                    Color p = Color.FromArgb(255, valueR, valueG, valueB);

                    img.SetPixel(i, j, p);
                }
            }


            return img;

        }

        /// <summary>
        /// Converts ARGB image to greyscale using luminance method
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Greyscaled image</returns>
        public Bitmap ToGreyscale(Bitmap OriginalImage)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB image to greyscale using average method
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Greyscaled image</returns>
        public Bitmap ToGreyscaleAVG(Bitmap OriginalImage)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((pixel.R + pixel.G + pixel.B) / 3);
                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB image to greyscale using lightness method
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Greyscaled image</returns>
        public Bitmap ToGreyscaleLightness(Bitmap OriginalImage)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            //int x, y;

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((Math.Max(pixel.R, Math.Max(pixel.G, pixel.B)) + Math.Min(pixel.R, Math.Min(pixel.G, pixel.B))) / 2);
                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB image to greyscale using luminance method and inverses it with respect to given threshold
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="threshold">Inverse threshold</param>
        /// <returns>Inversed image</returns>
        public Bitmap InverseImage(Bitmap OriginalImage, int threshold)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            if (threshold < 1 || threshold > 254)
            {
                throw new Exception("Threshold value must be in range from 1 to 254");
            }

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs1 = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    int distance = Math.Abs(threshold - gs1);

                    int gs = 0;

                    if (gs1 >= threshold) gs = threshold - distance;
                    if (gs1 < threshold) gs = threshold + distance;

                    if (gs > 255) gs = 255;
                    if (gs < 0) gs = 0;

                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }


        /// <summary>
        /// Converts ARGB image to greyscale using luminance method and calculates its negative
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Negative</returns>
        public Bitmap NegativeImageGS(Bitmap OriginalImage)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs1 = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    int gs = 255 - gs1;

                    if (gs > 255) gs = 255;
                    if (gs < 0) gs = 0;

                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Calculate image negative
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Negative</returns>
        public Bitmap NegativeImageColor(Bitmap OriginalImage)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs1R = (int)(pixel.R);
                    int gsR = 255 - gs1R;

                    int gs1G = (int)(pixel.G);
                    int gsG = 255 - gs1G;

                    int gs1B = (int)(pixel.B);
                    int gsB = 255 - gs1B;

                    if (gsR > 255) gsR = 255;
                    if (gsR < 0) gsR = 0;

                    if (gsG > 255) gsG = 255;
                    if (gsG < 0) gsG = 0;

                    if (gsB > 255) gsB = 255;
                    if (gsB < 0) gsB = 0;

                    Color newColor = Color.FromArgb(255, gsR, gsG, gsB);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and adds
        /// </summary>
        /// <param name="Left">Image</param>
        /// <param name="Right">Image</param>
        /// <returns>Product of addition</returns>
        public Bitmap AddImages(Bitmap Left, Bitmap Right)
        {

            if (Left.Width != Right.Width)
            {
                throw new Exception("Images dimension must be equal.");
            }

            if (Left.Height != Right.Height)
            {
                throw new Exception("Images dimension must be equal.");
            }


            Bitmap OutputImage = new System.Drawing.Bitmap(Left.Width, Left.Height);

            //int x, y;

            for (int x = 0; x < Left.Width; x++)
            {
                for (int y = 0; y < Left.Height; y++)
                {
                    Color pixelLeft = Left.GetPixel(x, y);
                    Color pixelRight = Right.GetPixel(x, y);
                    int gs1 = (int)((pixelLeft.R * 0.3) + (pixelLeft.G * 0.59) + (pixelLeft.B * 0.11));
                    int gs2 = (int)((pixelRight.R * 0.3) + (pixelRight.G * 0.59) + (pixelRight.B * 0.11));

                    int gs = gs1 + gs2;

                    if (gs > 255) gs = 255;
                    if (gs < 0) gs = 0;

                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and subtracts
        /// </summary>
        /// <param name="Left">Minuend image</param>
        /// <param name="Right">Subtrahend image</param>
        /// <returns>Product of subtraction</returns>
        public Bitmap SubtractImages(Bitmap Left, Bitmap Right)
        {

            if (Left.Width != Right.Width)
            {
                throw new Exception("Images dimension must be equal.");
            }

            if (Left.Height != Right.Height)
            {
                throw new Exception("Images dimension must be equal.");
            }


            Bitmap OutputImage = new System.Drawing.Bitmap(Left.Width, Left.Height);

            //int x, y;

            for (int x = 0; x < Left.Width; x++)
            {
                for (int y = 0; y < Left.Height; y++)
                {
                    Color pixelLeft = Left.GetPixel(x, y);
                    Color pixelRight = Right.GetPixel(x, y);
                    int gs1 = (int)((pixelLeft.R * 0.3) + (pixelLeft.G * 0.59) + (pixelLeft.B * 0.11));
                    int gs2 = (int)((pixelRight.R * 0.3) + (pixelRight.G * 0.59) + (pixelRight.B * 0.11));

                    int gs = gs1 - gs2;

                    if (gs > 255) gs = 255;
                    if (gs < 0) gs = 0;

                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB image to black and white and inverses it with respect to given threshold
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="threshold">Threshold</param>
        /// <returns>Balck and white image</returns>
        public Bitmap ToBlackwhite(Bitmap OriginalImage, int threshold)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            if (threshold < 1 || threshold > 254)
            {
                throw new Exception("Threshold value must be in range from 1 to 254");
            }

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    if (gs > threshold) gs = 255; else gs = 0;
                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB image to black and white and inverses it with respect to given threshold
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="threshold">Threshold</param>
        /// <returns>Balck and white image</returns>
        public Bitmap ToBlackwhiteInverse(Bitmap OriginalImage, int threshold)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            if (threshold < 1 || threshold > 254)
            {
                throw new Exception("Threshold value must be in range from 1 to 254");
            }

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    if (gs > threshold) gs = 0; else gs = 255;
                    Color newColor = Color.FromArgb(255, gs, gs, gs);
                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and returns histogram
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Image histogram (each list position corresponds to brightness level)</returns>
        public int[] Histogram(Bitmap OriginalImage)
        {
            int[] histogram = new int[256];

            for (int i = 0; i < 256; i++)
            {
                histogram[i] = 0;
            }

            for (int m = 0; m < OriginalImage.Width; m++)
            {
                for (int n = 0; n < OriginalImage.Height; n++)
                {
                    Color pixel = OriginalImage.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    histogram[gs]++;

                }
            }

            return histogram;

        }

        /// <summary>
        /// Returns color image histogram
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Image histogram (dimension 0 corresponds to color code (0 ->Red, 1 -> Green, 2 -> Blue), dimension 1 - each position corresponds to brightness level)</returns>
        public int[,] RGBHistogram(Bitmap OriginalImage)
        {
            int[,] histogram = new int[3, 256];

            for (int i = 0; i < 256; i++)
            {
                histogram[0, i] = 0;
                histogram[1, i] = 0;
                histogram[2, i] = 0;
            }

            for (int m = 0; m < OriginalImage.Width; m++)
            {
                for (int n = 0; n < OriginalImage.Height; n++)
                {
                    Color pixel = OriginalImage.GetPixel(m, n);

                    histogram[0, pixel.R]++;
                    histogram[1, pixel.G]++;
                    histogram[2, pixel.B]++;

                }
            }

            return histogram;
        }

        /// <summary>
        /// Returns image minimum brightness level
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Minimum brightness level in given image</returns>
        public int MinBrightness(Bitmap OriginalImage)
        {
            int min = 255;

            for (int m = 0; m < OriginalImage.Width; m++)
            {
                for (int n = 0; n < OriginalImage.Height; n++)
                {
                    Color pixel = OriginalImage.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    if (gs < min)
                    {
                        min = gs;
                    }
                }
            }

            return min;
        }

        /// <summary>
        /// Returns image maximum brightness level
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Maximum brightness level in given image</returns>
        public int MaxBrightness(Bitmap OriginalImage)
        {
            int max = 0;

            for (int m = 0; m < OriginalImage.Width; m++)
            {
                for (int n = 0; n < OriginalImage.Height; n++)
                {
                    Color pixel = OriginalImage.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    if (gs > max)
                    {
                        max = gs;
                    }
                }
            }

            return max;
        }

        /// <summary>
        /// onverts ARGB images to greyscale using luminance method and brighten using contrast stretching method.
        /// Brightness minimum and maximum available values are by default 0 and 255.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Brigthen greyscaled image</returns>
        public Bitmap ContrastStretching(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;

            int RMin = 0;
            int RMax = 255;

            int min = this.MinBrightness(image);
            int max = this.MaxBrightness(image);

            for (int m = 0; m < image.Width; m++)
            {
                for (int n = 0; n < image.Height; n++)
                {
                    Color pixel = image.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    Double tmp = (Convert.ToDouble(gs - min) / Convert.ToDouble(max - min)) * (RMax - RMin) + RMin;

                    int newgs = (int)tmp;

                    image.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));

                }
            }

            return image;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and brighten using contrast stretching method.
        /// Brightness minimum and maximum available values are by default 0 and 255.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="RMinSet">Minimum available brightness value</param>
        /// <param name="RMaxSet">Maximum available brightness value</param>
        /// <returns>Brigthen greyscaled image</returns>
        public Bitmap ContrastStretching(Bitmap OriginalImage, int RMinSet, int RMaxSet)
        {
            Bitmap image = OriginalImage;

            if (RMinSet >= RMaxSet)
            {
                throw new Exception("Minimum available brightness value must be lower then maximum available brightness value");
            }

            if (RMinSet < 0)
            {
                throw new Exception("Minimum available brightness value must be positive or zero");
            }

            if (RMaxSet > 255)
            {
                throw new Exception("Maximum available brightness value must be positive lower or equal 255");
            }

            int RMin = RMinSet;
            int RMax = RMaxSet;

            int min = this.MinBrightness(image);
            int max = this.MaxBrightness(image);

            for (int m = 0; m < image.Width; m++)
            {
                for (int n = 0; n < image.Height; n++)
                {
                    Color pixel = image.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    Double tmp = (Convert.ToDouble(gs - min) / Convert.ToDouble(max - min)) * (RMax - RMin) + RMin;

                    int newgs = (int)tmp;

                    image.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));

                }
            }

            return image;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and shifts its histogram with respect to given offset.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="offset">Shift offset</param>
        /// <returns>Shifted greyscaled image</returns>
        public Bitmap HistogramShift(Bitmap OriginalImage, int offset)
        {
            Bitmap image = OriginalImage;

            if (offset < 1 || offset > 254)
            {
                throw new Exception("Offset value must be in range from 1 to 254");
            }

            for (int m = 0; m < image.Width; m++)
            {
                for (int n = 0; n < image.Height; n++)
                {
                    Color pixel = image.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    int newgs = (int)(gs + offset);

                    image.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));

                }
            }

            return image;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and enhances contrast using equalization method.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Greyscaled contrast-enhances image</returns>
        public Bitmap HistoramEqualization(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;

            int[] histogram = this.Histogram(image);
            int pixelCount = image.Width * image.Height;

            for (int m = 0; m < image.Width; m++)
            {
                for (int n = 0; n < image.Height; n++)
                {
                    Color pixel = image.GetPixel(m, n);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    Double PSum = 0;

                    for (int i = 0; i < gs + 1; i++)
                    {
                        PSum += Convert.ToDouble(histogram[i]) / pixelCount;
                    }

                    int newgs = Convert.ToInt16(Math.Floor(255 * PSum));

                    image.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));
                }
            }

            return image;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image convolution with given filter mask.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <returns>Filtered greyscaled image</returns>
        public Bitmap ImageFilterGS(Bitmap OriginalImage, int[,] Filter)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValue += roi[k, l] * Filter[k, l];
                        }
                    }

                    //newValue = (int)(Convert.ToDouble(newValue)/9);

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));

                }
            }


            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image convolution with given filter mask.
        /// Normalization using given coefficient.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <param name="Coef">Normalization coefficient</param>
        /// <returns>Filtered greyscaled image</returns>
        public Bitmap ImageFilterGS(Bitmap OriginalImage, int[,] Filter, Double Coef)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValue += roi[k, l] * Filter[k, l];
                        }
                    }

                    newValue = (int)(Convert.ToDouble(newValue) / Coef);

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));

                }
            }


            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image convolution with given filter mask.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <returns>Filtered greyscaled image</returns>
        public Bitmap ImageFilterGS(Bitmap OriginalImage, Double[,] Filter)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    Double[,] roi = new Double[Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValue += (int)(roi[k, l] * Filter[k, l]);
                        }
                    }

                    //newValue = (int)(Convert.ToDouble(newValue)/9);

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));

                }
            }


            return image2;
        }

        /// <summary>
        /// Calculates image convolution with given filter mask.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageFilterColor(Bitmap OriginalImage, int[,] Filter)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,,] roi = new int[3, Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roi[0, tmpi, tmpj] = (int)pR;
                            roi[1, tmpi, tmpj] = (int)pG;
                            roi[2, tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValueR += roi[0, k, l] * Filter[k, l];
                            newValueG += roi[1, k, l] * Filter[k, l];
                            newValueB += roi[2, k, l] * Filter[k, l];
                        }
                    }

                    //newValue = (int)(Convert.ToDouble(newValue)/9);

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));

                }
            }


            return image2;
        }

        /// <summary>
        /// Calculates image convolution with given filter mask.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <param name="Coef">Normalization coefficient</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageFilterColor(Bitmap OriginalImage, int[,] Filter, Double Coef)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,,] roi = new int[3, Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roi[0, tmpi, tmpj] = (int)pR;
                            roi[1, tmpi, tmpj] = (int)pG;
                            roi[2, tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValueR += roi[0, k, l] * Filter[k, l];
                            newValueG += roi[1, k, l] * Filter[k, l];
                            newValueB += roi[2, k, l] * Filter[k, l];
                        }
                    }

                    newValueR = (int)(Convert.ToDouble(newValueR) / Coef);
                    newValueG = (int)(Convert.ToDouble(newValueG) / Coef);
                    newValueB = (int)(Convert.ToDouble(newValueB) / Coef);

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));

                }
            }


            return image2;
        }

        /// <summary>
        /// Calculates image convolution with given filter mask.
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Filter">Filter mask</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageFilterColor(Bitmap OriginalImage, Double[,] Filter)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Filter.GetLength(0) != Filter.GetLength(1))
            {
                throw new Exception("Filter mask must be square.");
            }

            if (Filter.GetLength(0) % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (Filter.GetLength(0) < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(Filter.GetLength(0) / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    Double[,,] roi = new Double[3, Filter.GetLength(0), Filter.GetLength(0)];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roi[0, tmpi, tmpj] = (int)pR;
                            roi[1, tmpi, tmpj] = (int)pG;
                            roi[2, tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    for (int k = 0; k < Filter.GetLength(0); k++)
                    {
                        for (int l = 0; l < Filter.GetLength(0); l++)
                        {
                            newValueR += (int)(roi[0, k, l] * Filter[k, l]);
                            newValueG += (int)(roi[1, k, l] * Filter[k, l]);
                            newValueB += (int)(roi[2, k, l] * Filter[k, l]);
                        }
                    }

                    //newValue = (int)(Convert.ToDouble(newValue)/9);

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));

                }
            }


            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates module of image convolution with Sobel operators (horizontal and vertical axis)
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageSobelFilterGS(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            for (int m = 1; m < image.Width - 1; m++)
            {
                for (int n = 1; n < image.Height - 1; n++)
                {

                    Color pixel1 = image.GetPixel(m - 1, n - 1);
                    Color pixel2 = image.GetPixel(m, n - 1);
                    Color pixel3 = image.GetPixel(m + 1, n - 1);
                    Color pixel4 = image.GetPixel(m - 1, n);
                    Color pixel5 = image.GetPixel(m, n);
                    Color pixel6 = image.GetPixel(m + 1, n);
                    Color pixel7 = image.GetPixel(m - 1, n + 1);
                    Color pixel8 = image.GetPixel(m, n + 1);
                    Color pixel9 = image.GetPixel(m + 1, n + 1);

                    Double p1 = Convert.ToDouble((pixel1.R * 0.3) + (pixel1.G * 0.59) + (pixel1.B * 0.11));
                    Double p2 = Convert.ToDouble((pixel2.R * 0.3) + (pixel2.G * 0.59) + (pixel2.B * 0.11));
                    Double p3 = Convert.ToDouble((pixel3.R * 0.3) + (pixel3.G * 0.59) + (pixel3.B * 0.11));
                    Double p4 = Convert.ToDouble((pixel4.R * 0.3) + (pixel4.G * 0.59) + (pixel4.B * 0.11));
                    Double p5 = Convert.ToDouble((pixel5.R * 0.3) + (pixel5.G * 0.59) + (pixel5.B * 0.11));
                    Double p6 = Convert.ToDouble((pixel6.R * 0.3) + (pixel6.G * 0.59) + (pixel6.B * 0.11));
                    Double p7 = Convert.ToDouble((pixel7.R * 0.3) + (pixel7.G * 0.59) + (pixel7.B * 0.11));
                    Double p8 = Convert.ToDouble((pixel8.R * 0.3) + (pixel8.G * 0.59) + (pixel8.B * 0.11));
                    Double p9 = Convert.ToDouble((pixel9.R * 0.3) + (pixel9.G * 0.59) + (pixel9.B * 0.11));


                    int x = (int)((p1 + (p2 + p2) + p3 - p7 - (p8 + p8) - p9));

                    int y = (int)((p3 + (p6 + p6) + p9 - p1 - (p4 + p4) - p7));

                    int newgs = (int)(Math.Abs(x) + Math.Abs(y));

                    if (newgs > 255) newgs = 255;
                    if (newgs < 0) newgs = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));
                }
            }


            return image2;
        }

        /// <summary>
        /// Calculates module of image convolution with Sobel operators (horizontal and vertical axis)
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageSobelFilterColor(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            for (int m = 1; m < image.Width - 1; m++)
            {
                for (int n = 1; n < image.Height - 1; n++)
                {

                    Color pixel1 = image.GetPixel(m - 1, n - 1);
                    Color pixel2 = image.GetPixel(m, n - 1);
                    Color pixel3 = image.GetPixel(m + 1, n - 1);
                    Color pixel4 = image.GetPixel(m - 1, n);
                    Color pixel5 = image.GetPixel(m, n);
                    Color pixel6 = image.GetPixel(m + 1, n);
                    Color pixel7 = image.GetPixel(m - 1, n + 1);
                    Color pixel8 = image.GetPixel(m, n + 1);
                    Color pixel9 = image.GetPixel(m + 1, n + 1);

                    Double p1r = Convert.ToDouble(pixel1.R);
                    Double p2r = Convert.ToDouble(pixel2.R);
                    Double p3r = Convert.ToDouble(pixel3.R);
                    Double p4r = Convert.ToDouble(pixel4.R);
                    Double p5r = Convert.ToDouble(pixel5.R);
                    Double p6r = Convert.ToDouble(pixel6.R);
                    Double p7r = Convert.ToDouble(pixel7.R);
                    Double p8r = Convert.ToDouble(pixel8.R);
                    Double p9r = Convert.ToDouble(pixel9.R);

                    Double p1g = Convert.ToDouble(pixel1.G);
                    Double p2g = Convert.ToDouble(pixel2.G);
                    Double p3g = Convert.ToDouble(pixel3.G);
                    Double p4g = Convert.ToDouble(pixel4.G);
                    Double p5g = Convert.ToDouble(pixel5.G);
                    Double p6g = Convert.ToDouble(pixel6.G);
                    Double p7g = Convert.ToDouble(pixel7.G);
                    Double p8g = Convert.ToDouble(pixel8.G);
                    Double p9g = Convert.ToDouble(pixel9.G);

                    Double p1b = Convert.ToDouble(pixel1.B);
                    Double p2b = Convert.ToDouble(pixel2.B);
                    Double p3b = Convert.ToDouble(pixel3.B);
                    Double p4b = Convert.ToDouble(pixel4.B);
                    Double p5b = Convert.ToDouble(pixel5.B);
                    Double p6b = Convert.ToDouble(pixel6.B);
                    Double p7b = Convert.ToDouble(pixel7.B);
                    Double p8b = Convert.ToDouble(pixel8.B);
                    Double p9b = Convert.ToDouble(pixel9.B);


                    int xr = (int)((p1r + (p2r + p2r) + p3r - p7r - (p8r + p8r) - p9r));
                    int yr = (int)((p3r + (p6r + p6r) + p9r - p1r - (p4r + p4r) - p7r));
                    int newgsr = (int)(Math.Abs(xr) + Math.Abs(yr));
                    if (newgsr > 255) newgsr = 255;
                    if (newgsr < 0) newgsr = 0;

                    int xg = (int)((p1g + (p2g + p2g) + p3g - p7g - (p8g + p8g) - p9g));
                    int yg = (int)((p3g + (p6g + p6g) + p9g - p1g - (p4g + p4g) - p7g));
                    int newgsg = (int)(Math.Abs(xg) + Math.Abs(yg));
                    if (newgsg > 255) newgsg = 255;
                    if (newgsg < 0) newgsg = 0;

                    int xb = (int)((p1b + (p2b + p2b) + p3b - p7b - (p8b + p8b) - p9b));
                    int yb = (int)((p3b + (p6b + p6b) + p9b - p1b - (p4b + p4b) - p7b));
                    int newgsb = (int)(Math.Abs(xb) + Math.Abs(yb));
                    if (newgsb > 255) newgsb = 255;
                    if (newgsb < 0) newgsb = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newgsr, newgsg, newgsb));
                }
            }


            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates module of image convolution with Prewitt operators (horizontal and vertical axis)
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImagePrewittFilterGS(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            for (int m = 1; m < image.Width - 1; m++)
            {
                for (int n = 1; n < image.Height - 1; n++)
                {

                    Color pixel1 = image.GetPixel(m - 1, n - 1);
                    Color pixel2 = image.GetPixel(m, n - 1);
                    Color pixel3 = image.GetPixel(m + 1, n - 1);
                    Color pixel4 = image.GetPixel(m - 1, n);
                    Color pixel5 = image.GetPixel(m, n);
                    Color pixel6 = image.GetPixel(m + 1, n);
                    Color pixel7 = image.GetPixel(m - 1, n + 1);
                    Color pixel8 = image.GetPixel(m, n + 1);
                    Color pixel9 = image.GetPixel(m + 1, n + 1);

                    Double p1 = Convert.ToDouble((pixel1.R * 0.3) + (pixel1.G * 0.59) + (pixel1.B * 0.11));
                    Double p2 = Convert.ToDouble((pixel2.R * 0.3) + (pixel2.G * 0.59) + (pixel2.B * 0.11));
                    Double p3 = Convert.ToDouble((pixel3.R * 0.3) + (pixel3.G * 0.59) + (pixel3.B * 0.11));
                    Double p4 = Convert.ToDouble((pixel4.R * 0.3) + (pixel4.G * 0.59) + (pixel4.B * 0.11));
                    Double p5 = Convert.ToDouble((pixel5.R * 0.3) + (pixel5.G * 0.59) + (pixel5.B * 0.11));
                    Double p6 = Convert.ToDouble((pixel6.R * 0.3) + (pixel6.G * 0.59) + (pixel6.B * 0.11));
                    Double p7 = Convert.ToDouble((pixel7.R * 0.3) + (pixel7.G * 0.59) + (pixel7.B * 0.11));
                    Double p8 = Convert.ToDouble((pixel8.R * 0.3) + (pixel8.G * 0.59) + (pixel8.B * 0.11));
                    Double p9 = Convert.ToDouble((pixel9.R * 0.3) + (pixel9.G * 0.59) + (pixel9.B * 0.11));


                    int x = (int)((p1 + p2 + p3 - p7 - p8 - p9));

                    int y = (int)(p1 - p3 + p4 - p6 + p7 - p9);

                    int newgs = (int)(Math.Abs(x) + Math.Abs(y));

                    if (newgs > 255) newgs = 255;
                    if (newgs < 0) newgs = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newgs, newgs, newgs));
                }
            }


            return image2;
        }

        /// <summary>
        /// Calculates module of image convolution with Prewitt operators (horizontal and vertical axis)
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImagePrewittFilterColor(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            for (int m = 1; m < image.Width - 1; m++)
            {
                for (int n = 1; n < image.Height - 1; n++)
                {

                    Color pixel1 = image.GetPixel(m - 1, n - 1);
                    Color pixel2 = image.GetPixel(m, n - 1);
                    Color pixel3 = image.GetPixel(m + 1, n - 1);
                    Color pixel4 = image.GetPixel(m - 1, n);
                    Color pixel5 = image.GetPixel(m, n);
                    Color pixel6 = image.GetPixel(m + 1, n);
                    Color pixel7 = image.GetPixel(m - 1, n + 1);
                    Color pixel8 = image.GetPixel(m, n + 1);
                    Color pixel9 = image.GetPixel(m + 1, n + 1);

                    Double p1r = Convert.ToDouble(pixel1.R);
                    Double p2r = Convert.ToDouble(pixel2.R);
                    Double p3r = Convert.ToDouble(pixel3.R);
                    Double p4r = Convert.ToDouble(pixel4.R);
                    Double p5r = Convert.ToDouble(pixel5.R);
                    Double p6r = Convert.ToDouble(pixel6.R);
                    Double p7r = Convert.ToDouble(pixel7.R);
                    Double p8r = Convert.ToDouble(pixel8.R);
                    Double p9r = Convert.ToDouble(pixel9.R);

                    Double p1g = Convert.ToDouble(pixel1.G);
                    Double p2g = Convert.ToDouble(pixel2.G);
                    Double p3g = Convert.ToDouble(pixel3.G);
                    Double p4g = Convert.ToDouble(pixel4.G);
                    Double p5g = Convert.ToDouble(pixel5.G);
                    Double p6g = Convert.ToDouble(pixel6.G);
                    Double p7g = Convert.ToDouble(pixel7.G);
                    Double p8g = Convert.ToDouble(pixel8.G);
                    Double p9g = Convert.ToDouble(pixel9.G);

                    Double p1b = Convert.ToDouble(pixel1.B);
                    Double p2b = Convert.ToDouble(pixel2.B);
                    Double p3b = Convert.ToDouble(pixel3.B);
                    Double p4b = Convert.ToDouble(pixel4.B);
                    Double p5b = Convert.ToDouble(pixel5.B);
                    Double p6b = Convert.ToDouble(pixel6.B);
                    Double p7b = Convert.ToDouble(pixel7.B);
                    Double p8b = Convert.ToDouble(pixel8.B);
                    Double p9b = Convert.ToDouble(pixel9.B);


                    int xr = (int)(p1r + p2r + p3r - p7r - p8r - p9r);
                    int yr = (int)(p1r - p3r + p4r - p6r + p7r - p9r);
                    int newgsr = (int)(Math.Abs(xr) + Math.Abs(yr));
                    if (newgsr > 255) newgsr = 255;
                    if (newgsr < 0) newgsr = 0;

                    int xg = (int)(p1g + p2g + p3g - p7g - p8g - p9g);
                    int yg = (int)(p1g - p3g + p4g - p6g + p7g - p9g);
                    int newgsg = (int)(Math.Abs(xg) + Math.Abs(yg));
                    if (newgsg > 255) newgsg = 255;
                    if (newgsg < 0) newgsg = 0;

                    int xb = (int)(p1b + p2b + p3b - p7b - p8b - p9b);
                    int yb = (int)(p1b - p3b + p4b - p6b + p7b - p9b);
                    int newgsb = (int)(Math.Abs(xb) + Math.Abs(yb));
                    if (newgsb > 255) newgsb = 255;
                    if (newgsb < 0) newgsb = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newgsr, newgsg, newgsb));
                }
            }


            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with median mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Median mask dimension</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageMedianFilterGS(Bitmap OriginalImage, int size)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("Median filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[] roi = new int[size * size];

                    int tmp = 0;
                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmp] = (int)p;

                            tmp++;
                        }
                    }


                    System.Array.Sort(roi);

                    decimal Median = 0;
                    int sizeROI = roi.Length;
                    int mid = sizeROI / 2;
                    Median = (sizeROI % 2 != 0) ? (decimal)roi[mid] : ((decimal)roi[mid] + (decimal)roi[mid + 1]) / 2;

                    newValue = (int)Median;

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Calculates image filtartion with median mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Median mask dimension</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageMedianFilterColor(Bitmap OriginalImage, int size)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("Median filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[] roiR = new int[size * size];
                    int[] roiG = new int[size * size];
                    int[] roiB = new int[size * size];

                    int tmp = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roiR[tmp] = (int)pR;
                            roiG[tmp] = (int)pG;
                            roiB[tmp] = (int)pB;

                            tmp++;
                        }

                    }




                    System.Array.Sort(roiR);
                    System.Array.Sort(roiB);
                    System.Array.Sort(roiG);

                    decimal MedianR = 0;
                    decimal MedianG = 0;
                    decimal MedianB = 0;
                    int sizeROI = roiR.Length;
                    int mid = sizeROI / 2;
                    MedianR = (sizeROI % 2 != 0) ? (decimal)roiR[mid] : ((decimal)roiR[mid] + (decimal)roiR[mid + 1]) / 2;
                    MedianG = (sizeROI % 2 != 0) ? (decimal)roiG[mid] : ((decimal)roiG[mid] + (decimal)roiG[mid + 1]) / 2;
                    MedianB = (sizeROI % 2 != 0) ? (decimal)roiB[mid] : ((decimal)roiB[mid] + (decimal)roiB[mid + 1]) / 2;

                    newValueR = (int)MedianR;

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    newValueG = (int)MedianG;

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    newValueB = (int)MedianB;

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with erosion mask of 3 x 3 dimension.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageErosionFilterGS(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            int size = 3;
            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    newValue = (int)(roivector.Min());

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with erosion mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Erosion mask dimension</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageErosionFilterGS(Bitmap OriginalImage, int size)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("Filter filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    newValue = (int)(roivector.Min());

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with dilatation mask of 3 x 3 dimension.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageDilatationFilterGS(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            int size = 3;
            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    newValue = (int)(roivector.Max());

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with dilatation mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Dilatation mask dimension</param>
        /// <returns>Filtered image</returns>
        public Bitmap ImageDilatationFilterGS(Bitmap OriginalImage, int size)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("Filter filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    newValue = (int)(roivector.Max());

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with SD-ROM mask of size 3.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageSDROMFilterGS(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            int[] thresholds = new int[4] { 20, 40, 60, 80 };
            int size = 3;

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    Color CPixel = image.GetPixel(m, n);
                    int CP = (int)Convert.ToDouble((CPixel.R * 0.3) + (CPixel.G * 0.59) + (CPixel.B * 0.11));

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    System.Array.Sort(roivector);

                    int ROM = 0;
                    int sizeROI = roivector.Length;
                    int mid = sizeROI / 2 - 1;

                    Double a = Convert.ToDouble(roivector[mid]);
                    Double b = Convert.ToDouble(roivector[mid + 1]);
                    Double c = (a + b) / 2;

                    ROM = (int)c;

                    int[] ROD = new int[mid + 1];

                    for (int i = 0; i < mid; i++)
                    {
                        if (CP <= ROM)
                        {
                            ROD[i] = roivector[i] - CP;
                        }
                        else
                        {
                            ROD[i] = CP - roivector[roivector.GetLength(0) - 1 - i];
                        }
                    }

                    newValue = CP;

                    for (int i = 0; i < mid; i++)
                    {
                        if (ROD[i] > thresholds[i])
                        {
                            newValue = ROM;
                            break;
                        }
                    }


                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Converts ARGB images to greyscale using luminance method and calculates image filtartion with SD-ROM mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">SD-ROM mask size</param>
        /// <param name="thresholds">Array of thresholds</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageSDROMFilterGS(Bitmap OriginalImage, int size, int[] thresholds)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("SDROM filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("SDROM filter dimension must be positive greater or equal 3.");
            }

            if (thresholds.GetLength(0) != (int)((size * size - 1) / 2))
            {
                throw new Exception("Thresholds list size must be " + (int)((size * size - 1) / 2) + " for used mask dimension");
            }

            for (int i = 0; i < thresholds.GetLength(0) - 1; i++)
            {
                if (thresholds[i] >= thresholds[i + 1])
                {
                    throw new Exception("Each next element of thresholds list must be greater than previous one.");
                }
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    Color CPixel = image.GetPixel(m, n);
                    int CP = (int)Convert.ToDouble((CPixel.R * 0.3) + (CPixel.G * 0.59) + (CPixel.B * 0.11));

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivector = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < roi.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivector[tmp] = roi[i, j];
                                tmp++;
                            }
                        }
                    }

                    System.Array.Sort(roivector);

                    int ROM = 0;
                    int sizeROI = roivector.Length;
                    int mid = sizeROI / 2 - 1;

                    Double a = Convert.ToDouble(roivector[mid]);
                    Double b = Convert.ToDouble(roivector[mid + 1]);
                    Double c = (a + b) / 2;

                    ROM = (int)c;

                    int[] ROD = new int[mid + 1];

                    for (int i = 0; i < mid; i++)
                    {
                        if (CP <= ROM)
                        {
                            ROD[i] = roivector[i] - CP;
                        }
                        else
                        {
                            ROD[i] = CP - roivector[roivector.GetLength(0) - 1 - i];
                        }
                    }

                    newValue = CP;

                    for (int i = 0; i < mid; i++)
                    {
                        if (ROD[i] > thresholds[i])
                        {
                            newValue = ROM;
                            break;
                        }
                    }


                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Ccalculates image filtartion with SD-ROM mask of size 3.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageSDROMFilterColor(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            int[] thresholds = new int[4] { 20, 40, 60, 80 };
            int size = 3;

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roiR = new int[size, size];
                    int[,] roiG = new int[size, size];
                    int[,] roiB = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    Color CPixel = image.GetPixel(m, n);
                    int CPR = (int)(CPixel.R);
                    int CPG = (int)(CPixel.G);
                    int CPB = (int)(CPixel.B);

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roiR[tmpi, tmpj] = (int)pR;
                            roiG[tmpi, tmpj] = (int)pG;
                            roiB[tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivectorR = new int[size * size - 1];
                    int[] roivectorG = new int[size * size - 1];
                    int[] roivectorB = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roiR.GetLength(0); i++)
                    {
                        for (int j = 0; j < roiR.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivectorR[tmp] = roiR[i, j];
                                roivectorG[tmp] = roiG[i, j];
                                roivectorB[tmp] = roiB[i, j];
                                tmp++;
                            }
                        }
                    }

                    System.Array.Sort(roivectorR);
                    System.Array.Sort(roivectorG);
                    System.Array.Sort(roivectorB);

                    int ROMR = 0;
                    int ROMG = 0;
                    int ROMB = 0;
                    int sizeROI = roivectorR.Length;
                    int mid = sizeROI / 2 - 1;

                    Double a = Convert.ToDouble(roivectorR[mid]);
                    Double b = Convert.ToDouble(roivectorR[mid + 1]);
                    Double c = (a + b) / 2;
                    ROMR = (int)c;

                    a = Convert.ToDouble(roivectorG[mid]);
                    b = Convert.ToDouble(roivectorG[mid + 1]);
                    c = (a + b) / 2;
                    ROMG = (int)c;

                    a = Convert.ToDouble(roivectorB[mid]);
                    b = Convert.ToDouble(roivectorB[mid + 1]);
                    c = (a + b) / 2;
                    ROMB = (int)c;

                    int[] RODR = new int[mid + 1];
                    int[] RODG = new int[mid + 1];
                    int[] RODB = new int[mid + 1];

                    for (int i = 0; i < mid; i++)
                    {
                        if (CPR <= ROMR)
                        {
                            RODR[i] = roivectorR[i] - CPR;
                        }
                        else
                        {
                            RODR[i] = CPR - roivectorR[roivectorR.GetLength(0) - 1 - i];
                        }

                        if (CPG <= ROMG)
                        {
                            RODG[i] = roivectorG[i] - CPG;
                        }
                        else
                        {
                            RODG[i] = CPG - roivectorG[roivectorG.GetLength(0) - 1 - i];
                        }

                        if (CPB <= ROMB)
                        {
                            RODB[i] = roivectorB[i] - CPB;
                        }
                        else
                        {
                            RODB[i] = CPB - roivectorB[roivectorB.GetLength(0) - 1 - i];
                        }
                    }

                    newValueR = CPR;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODR[i] > thresholds[i])
                        {
                            newValueR = ROMR;
                            break;
                        }
                    }

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    newValueG = CPG;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODG[i] > thresholds[i])
                        {
                            newValueG = ROMG;
                            break;
                        }
                    }

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    newValueB = CPB;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODB[i] > thresholds[i])
                        {
                            newValueB = ROMB;
                            break;
                        }
                    }

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));
                }
            }

            return image2;
        }

        /// <summary>
        /// Calculates image filtartion with SD-ROM mask of given size.
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">SD-ROM mask size</param>
        /// <param name="thresholds">Array of thresholds</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageSDROMFilterColor(Bitmap OriginalImage, int size, int[] thresholds)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (size % 2 == 0)
            {
                throw new Exception("SDROM filter dimension must be odd.");
            }

            if (size < 3)
            {
                throw new Exception("SDROM filter dimension must be positive greater or equal 3.");
            }

            if (thresholds.GetLength(0) != (int)((size * size - 1) / 2))
            {
                throw new Exception("Thresholds list size must be " + (int)((size * size - 1) / 2) + " for used mask dimension");
            }

            for (int i = 0; i < thresholds.GetLength(0) - 1; i++)
            {
                if (thresholds[i] >= thresholds[i + 1])
                {
                    throw new Exception("Each next element of thresholds list must be greater than previous one.");
                }
            }

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roiR = new int[size, size];
                    int[,] roiG = new int[size, size];
                    int[,] roiB = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    Color CPixel = image.GetPixel(m, n);
                    int CPR = (int)(CPixel.R);
                    int CPG = (int)(CPixel.G);
                    int CPB = (int)(CPixel.B);

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roiR[tmpi, tmpj] = (int)pR;
                            roiG[tmpi, tmpj] = (int)pG;
                            roiB[tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] roivectorR = new int[size * size - 1];
                    int[] roivectorG = new int[size * size - 1];
                    int[] roivectorB = new int[size * size - 1];

                    int tmp = 0;

                    for (int i = 0; i < roiR.GetLength(0); i++)
                    {
                        for (int j = 0; j < roiR.GetLength(1); j++)
                        {

                            if (i == range && j == range)
                            {

                            }
                            else
                            {
                                roivectorR[tmp] = roiR[i, j];
                                roivectorG[tmp] = roiG[i, j];
                                roivectorB[tmp] = roiB[i, j];
                                tmp++;
                            }
                        }
                    }

                    System.Array.Sort(roivectorR);
                    System.Array.Sort(roivectorG);
                    System.Array.Sort(roivectorB);

                    int ROMR = 0;
                    int ROMG = 0;
                    int ROMB = 0;
                    int sizeROI = roivectorR.Length;
                    int mid = sizeROI / 2 - 1;

                    Double a = Convert.ToDouble(roivectorR[mid]);
                    Double b = Convert.ToDouble(roivectorR[mid + 1]);
                    Double c = (a + b) / 2;
                    ROMR = (int)c;

                    a = Convert.ToDouble(roivectorG[mid]);
                    b = Convert.ToDouble(roivectorG[mid + 1]);
                    c = (a + b) / 2;
                    ROMG = (int)c;

                    a = Convert.ToDouble(roivectorB[mid]);
                    b = Convert.ToDouble(roivectorB[mid + 1]);
                    c = (a + b) / 2;
                    ROMB = (int)c;

                    int[] RODR = new int[mid + 1];
                    int[] RODG = new int[mid + 1];
                    int[] RODB = new int[mid + 1];

                    for (int i = 0; i < mid; i++)
                    {
                        if (CPR <= ROMR)
                        {
                            RODR[i] = roivectorR[i] - CPR;
                        }
                        else
                        {
                            RODR[i] = CPR - roivectorR[roivectorR.GetLength(0) - 1 - i];
                        }

                        if (CPG <= ROMG)
                        {
                            RODG[i] = roivectorG[i] - CPG;
                        }
                        else
                        {
                            RODG[i] = CPG - roivectorG[roivectorG.GetLength(0) - 1 - i];
                        }

                        if (CPB <= ROMB)
                        {
                            RODB[i] = roivectorB[i] - CPB;
                        }
                        else
                        {
                            RODB[i] = CPB - roivectorB[roivectorB.GetLength(0) - 1 - i];
                        }
                    }

                    newValueR = CPR;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODR[i] > thresholds[i])
                        {
                            newValueR = ROMR;
                            break;
                        }
                    }

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    newValueG = CPG;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODG[i] > thresholds[i])
                        {
                            newValueG = ROMG;
                            break;
                        }
                    }

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    newValueB = CPB;

                    for (int i = 0; i < mid; i++)
                    {
                        if (RODB[i] > thresholds[i])
                        {
                            newValueB = ROMB;
                            break;
                        }
                    }

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));
                }
            }

            return image2;
        }

        /// <summary>
        /// Image to greyscale convertion and opening with 3x3 element
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Result of opening operation</returns>
        public Bitmap ImageOpenGS(Bitmap OriginalImage)
        {
            Bitmap image = this.ImageDilatationFilterGS(this.ImageErosionFilterGS(OriginalImage));

            return image;
        }

        /// <summary>
        /// Image to greyscale convertion and opening with element of given size
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Opening element size</param>
        /// <returns>Result of opening operation</returns>
        public Bitmap ImageOpenGS(Bitmap OriginalImage, int size)
        {
            Bitmap image = this.ImageDilatationFilterGS(this.ImageErosionFilterGS(OriginalImage, size), size);

            return image;
        }

        /// <summary>
        /// Image to greyscale convertion and closing with 3x3 element
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <returns>Result of closing operation</returns>
        public Bitmap ImageCloseGS(Bitmap OriginalImage)
        {
            Bitmap image = this.ImageErosionFilterGS(this.ImageDilatationFilterGS(OriginalImage));

            return image;
        }

        /// <summary>
        /// Image to greyscale convertion and opening with element of given size
        /// </summary>
        /// <param name="OriginalImage">Orignal ARGB image</param>
        /// <param name="size">Opening element size</param>
        /// <returns>Result of opening operation</returns>
        public Bitmap ImageCloseGS(Bitmap OriginalImage, int size)
        {
            Bitmap image = this.ImageErosionFilterGS(this.ImageDilatationFilterGS(OriginalImage, size), size);

            return image;
        }

        /// <summary>
        /// Image color filtration with defined color filter
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="color">Color filter. Available color filters are: Magenta, Yellow, Cyan, Magenta-Yellow, Cyan-Magenta, Yellow-Cyan</param>
        /// <returns>Result of color filtration</returns>
        public Bitmap ColorFiltration(Bitmap OriginalImage, string color)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            if (color != "Magenta" && color != "Yellow" && color != "Cyan" && color != "Magenta-Yellow" && color != "Cyan-Magenta" && color != "Yellow-Cyan")
            {
                throw new Exception("Available color filters are: Magenta, Yellow, Cyan, Magenta-Yellow, Cyan-Magenta, Yellow-Cyan");
            }

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);

                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;

                    Color newColor;

                    switch (color)
                    {
                        case "Magenta":
                            newColor = Color.FromArgb(255, red, 0, blue);
                            break;

                        case "Yellow":
                            newColor = Color.FromArgb(255, red, green, 0);
                            break;

                        case "Cyan":
                            newColor = Color.FromArgb(255, 0, green, blue);
                            break;

                        case "Magenta-Yellow":
                            newColor = Color.FromArgb(255, red, 0, 0);
                            break;

                        case "Yellow-Cyan":
                            newColor = Color.FromArgb(255, 0, green, 0);
                            break;

                        case "Cyan-Magenta":
                            newColor = Color.FromArgb(255, 0, 0, blue);
                            break;

                        default:
                            newColor = Color.FromArgb(255, red, green, blue);
                            break;

                    }


                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Converts image to greyscale and perform gamma correction
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Gamma">Gamma correction coefficient</param>
        /// <returns>Gamma corrected image</returns>
        public Bitmap GammaCorrection(Bitmap OriginalImage, Double Gamma)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);

                    int red = (int)(255 * Math.Pow(Convert.ToDouble(pixel.R) / 255, Gamma));
                    int green = (int)(255 * Math.Pow(Convert.ToDouble(pixel.G) / 255, Gamma));
                    int blue = (int)(255 * Math.Pow(Convert.ToDouble(pixel.B) / 255, Gamma));

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;

                    if (green > 255) green = 255;
                    if (green < 0) green = 0;

                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;

                    Color newColor = Color.FromArgb(255, red, green, blue); ;


                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Gamma correction
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Gamma">Gamma correction coefficient</param>
        /// <returns>Gamma corrected image</returns>
        public Bitmap GammaCorrectionGS(Bitmap OriginalImage, Double Gamma)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {

                    Color pixel = OriginalImage.GetPixel(x, y);
                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    gs = (int)(255 * Math.Pow(Convert.ToDouble(gs) / 255, Gamma));

                    if (gs > 255) gs = 255;
                    if (gs < 0) gs = 0;

                    Color newColor = Color.FromArgb(255, gs, gs, gs); ;


                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Sepia filtration
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="Coef">Sepia level</param>
        /// <returns>Sepia image</returns>
        public Bitmap Sepia(Bitmap OriginalImage, Double Coef)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);

                    int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                    int red = (int)(gs + 2 * Coef);
                    int green = (int)(gs + Coef);
                    int blue = (int)(gs);

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;

                    if (green > 255) green = 255;
                    if (green < 0) green = 0;

                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;

                    Color newColor = Color.FromArgb(255, red, green, blue); ;


                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }


        /// <summary>
        /// Color accent filtration
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="h">Hue of accented color</param>
        /// <param name="range">Range of acceptance</param>
        /// <returns>Color accent filtration</returns>
        public Bitmap ColorAccent(Bitmap OriginalImage, Double h, Double range)
        {
            Bitmap OutputImage = new System.Drawing.Bitmap(OriginalImage.Width, OriginalImage.Height);

            Double h1 = (h - range / 2 + 360) % 360;
            Double h2 = (h + range / 2 + 360) % 360;


            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    Color pixel = OriginalImage.GetPixel(x, y);
                    Double[] hsv = this.rgb2hsv(pixel);
                    int red = 0, green = 0, blue = 0;

                    //if (hsv[0] 

                    if (h1 <= h2)
                    {
                        if (hsv[0] <= h2 && hsv[0] >= h1)
                        {
                            red = pixel.R;
                            green = pixel.G;
                            blue = pixel.B;
                        }
                        else
                        {
                            int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                            red = gs;
                            green = gs;
                            blue = gs;
                        }
                    }
                    else
                    {
                        if (hsv[0] <= h2 || hsv[0] >= h1)
                        {
                            red = pixel.R;
                            green = pixel.G;
                            blue = pixel.B;
                        }
                        else
                        {
                            int gs = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                            red = gs;
                            green = gs;
                            blue = gs;
                        }
                    }

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;

                    if (green > 255) green = 255;
                    if (green < 0) green = 0;

                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;

                    Color newColor = Color.FromArgb(255, red, green, blue); ;

                    OutputImage.SetPixel(x, y, newColor);
                }
            }

            return OutputImage;
        }

        /// <summary>
        /// Image to greyscale convertion and kuwahara filtration
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="FilterSize">Kuwahara filter size</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageKuwaharaFilterGS(Bitmap OriginalImage, int FilterSize)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (FilterSize % 2 == 0)
            {
                throw new Exception("Filter size must be odd.");
            }

            if (FilterSize < 3)
            {
                throw new Exception("Filter size must be positive greater than 2.");
            }

            int size = 2 * FilterSize - 1;

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,] roi = new int[size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValue = 0;

                    Color CPixel = image.GetPixel(m, n);

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double p = Convert.ToDouble((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));

                            roi[tmpi, tmpj] = (int)p;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    int[] roivector1 = new int[FilterSize * FilterSize];
                    int[] roivector2 = new int[FilterSize * FilterSize];
                    int[] roivector3 = new int[FilterSize * FilterSize];
                    int[] roivector4 = new int[FilterSize * FilterSize];

                    int tmp1 = 0;
                    for (int i = 0; i < FilterSize; i++)
                    {
                        for (int j = 0; j < FilterSize; j++)
                        {


                            roivector1[tmp1] = roi[i, j];
                            tmp1++;

                        }
                    }

                    int tmp2 = 0;
                    for (int i = 0; i < FilterSize; i++)
                    {
                        for (int j = (FilterSize - 1); j < roi.GetLength(1); j++)
                        {


                            roivector2[tmp2] = roi[i, j];
                            tmp2++;

                        }
                    }

                    int tmp3 = 0;
                    for (int i = (FilterSize - 1); i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < FilterSize; j++)
                        {


                            roivector3[tmp3] = roi[i, j];
                            tmp3++;

                        }
                    }

                    int tmp4 = 0;
                    for (int i = (FilterSize - 1); i < roi.GetLength(0); i++)
                    {
                        for (int j = (FilterSize - 1); j < roi.GetLength(1); j++)
                        {


                            roivector4[tmp4] = roi[i, j];
                            tmp4++;

                        }
                    }


                    Double[] avg = new Double[4] { 0, 0, 0, 0 };

                    Double[] var = new Double[4] { 0, 0, 0, 0 };

                    Double[] std = new Double[4] { 0, 0, 0, 0 };

                    for (int i = 0; i < FilterSize * FilterSize; i++)
                    {

                        avg[0] += Convert.ToDouble(roivector1[i]) / (FilterSize * FilterSize);
                        avg[1] += Convert.ToDouble(roivector2[i]) / (FilterSize * FilterSize);
                        avg[2] += Convert.ToDouble(roivector3[i]) / (FilterSize * FilterSize);
                        avg[3] += Convert.ToDouble(roivector4[i]) / (FilterSize * FilterSize);

                    }

                    for (int i = 0; i < FilterSize * FilterSize; i++)
                    {

                        var[0] += Math.Pow((Convert.ToDouble(roivector1[i]) - avg[0]), 2) / (FilterSize * FilterSize);
                        var[1] += Math.Pow((Convert.ToDouble(roivector2[i]) - avg[1]), 2) / (FilterSize * FilterSize);
                        var[2] += Math.Pow((Convert.ToDouble(roivector3[i]) - avg[2]), 2) / (FilterSize * FilterSize);
                        var[3] += Math.Pow((Convert.ToDouble(roivector4[i]) - avg[3]), 2) / (FilterSize * FilterSize);

                    }


                    int minIndex = System.Array.IndexOf(var, var.Min());

                    newValue = (int)avg[minIndex];

                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValue, newValue, newValue));
                }
            }

            return image2;
        }

        /// <summary>
        /// Kuwahara filtration
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="FilterSize">Kuwahara filter size</param>
        /// <returns>Filtred image</returns>
        public Bitmap ImageKuwaharaFilterColor(Bitmap OriginalImage, int FilterSize)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (FilterSize % 2 == 0)
            {
                throw new Exception("Filter size must be odd.");
            }

            if (FilterSize < 3)
            {
                throw new Exception("Filter size must be positive greater than 2.");
            }

            int size = 2 * FilterSize - 1;

            int range = (int)Math.Floor(Convert.ToDouble(size / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    int[,,] roi = new int[3, size, size];

                    int tmpj = 0;
                    int tmpi = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    Color CPixel = image.GetPixel(m, n);

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pr = Convert.ToDouble(pixel.R);
                            Double pg = Convert.ToDouble(pixel.G);
                            Double pb = Convert.ToDouble(pixel.B);

                            roi[0, tmpi, tmpj] = (int)pr;
                            roi[1, tmpi, tmpj] = (int)pg;
                            roi[2, tmpi, tmpj] = (int)pb;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }


                    int[,] roivector1 = new int[3, FilterSize * FilterSize];
                    int[,] roivector2 = new int[3, FilterSize * FilterSize];
                    int[,] roivector3 = new int[3, FilterSize * FilterSize];
                    int[,] roivector4 = new int[3, FilterSize * FilterSize];

                    int tmp1 = 0;
                    for (int i = 0; i < FilterSize; i++)
                    {
                        for (int j = 0; j < FilterSize; j++)
                        {


                            roivector1[0, tmp1] = roi[0, i, j];
                            roivector1[1, tmp1] = roi[1, i, j];
                            roivector1[2, tmp1] = roi[2, i, j];
                            tmp1++;

                        }
                    }

                    int tmp2 = 0;
                    for (int i = 0; i < FilterSize; i++)
                    {
                        for (int j = (FilterSize - 1); j < roi.GetLength(1); j++)
                        {


                            roivector2[0, tmp2] = roi[0, i, j];
                            roivector2[1, tmp2] = roi[1, i, j];
                            roivector2[2, tmp2] = roi[2, i, j];
                            tmp2++;

                        }
                    }

                    int tmp3 = 0;
                    for (int i = (FilterSize - 1); i < roi.GetLength(0); i++)
                    {
                        for (int j = 0; j < FilterSize; j++)
                        {


                            roivector3[0, tmp3] = roi[0, i, j];
                            roivector3[1, tmp3] = roi[1, i, j];
                            roivector3[2, tmp3] = roi[2, i, j];
                            tmp3++;

                        }
                    }

                    int tmp4 = 0;
                    for (int i = (FilterSize - 1); i < roi.GetLength(0); i++)
                    {
                        for (int j = (FilterSize - 1); j < roi.GetLength(1); j++)
                        {


                            roivector4[0, tmp4] = roi[0, i, j];
                            roivector4[1, tmp4] = roi[1, i, j];
                            roivector4[2, tmp4] = roi[2, i, j];
                            tmp4++;

                        }
                    }
                    // tutaj

                    Double[] avgR = new Double[4] { 0, 0, 0, 0 };
                    Double[] avgG = new Double[4] { 0, 0, 0, 0 };
                    Double[] avgB = new Double[4] { 0, 0, 0, 0 };

                    Double[] varR = new Double[4] { 0, 0, 0, 0 };
                    Double[] varG = new Double[4] { 0, 0, 0, 0 };
                    Double[] varB = new Double[4] { 0, 0, 0, 0 };

                    for (int i = 0; i < FilterSize * FilterSize; i++)
                    {

                        avgR[0] += Convert.ToDouble(roivector1[0, i]) / (FilterSize * FilterSize);
                        avgR[1] += Convert.ToDouble(roivector2[0, i]) / (FilterSize * FilterSize);
                        avgR[2] += Convert.ToDouble(roivector3[0, i]) / (FilterSize * FilterSize);
                        avgR[3] += Convert.ToDouble(roivector4[0, i]) / (FilterSize * FilterSize);

                        avgG[0] += Convert.ToDouble(roivector1[1, i]) / (FilterSize * FilterSize);
                        avgG[1] += Convert.ToDouble(roivector2[1, i]) / (FilterSize * FilterSize);
                        avgG[2] += Convert.ToDouble(roivector3[1, i]) / (FilterSize * FilterSize);
                        avgG[3] += Convert.ToDouble(roivector4[1, i]) / (FilterSize * FilterSize);

                        avgB[0] += Convert.ToDouble(roivector1[2, i]) / (FilterSize * FilterSize);
                        avgB[1] += Convert.ToDouble(roivector2[2, i]) / (FilterSize * FilterSize);
                        avgB[2] += Convert.ToDouble(roivector3[2, i]) / (FilterSize * FilterSize);
                        avgB[3] += Convert.ToDouble(roivector4[2, i]) / (FilterSize * FilterSize);

                    }

                    for (int i = 0; i < FilterSize * FilterSize; i++)
                    {

                        varR[0] += Math.Pow((Convert.ToDouble(roivector1[0, i]) - avgR[0]), 2) / (FilterSize * FilterSize);
                        varR[1] += Math.Pow((Convert.ToDouble(roivector2[0, i]) - avgR[1]), 2) / (FilterSize * FilterSize);
                        varR[2] += Math.Pow((Convert.ToDouble(roivector3[0, i]) - avgR[2]), 2) / (FilterSize * FilterSize);
                        varR[3] += Math.Pow((Convert.ToDouble(roivector4[0, i]) - avgR[3]), 2) / (FilterSize * FilterSize);

                        varG[0] += Math.Pow((Convert.ToDouble(roivector1[1, i]) - avgG[0]), 2) / (FilterSize * FilterSize);
                        varG[1] += Math.Pow((Convert.ToDouble(roivector2[1, i]) - avgG[1]), 2) / (FilterSize * FilterSize);
                        varG[2] += Math.Pow((Convert.ToDouble(roivector3[1, i]) - avgG[2]), 2) / (FilterSize * FilterSize);
                        varG[3] += Math.Pow((Convert.ToDouble(roivector4[1, i]) - avgG[3]), 2) / (FilterSize * FilterSize);

                        varB[0] += Math.Pow((Convert.ToDouble(roivector1[2, i]) - avgB[0]), 2) / (FilterSize * FilterSize);
                        varB[1] += Math.Pow((Convert.ToDouble(roivector2[2, i]) - avgB[1]), 2) / (FilterSize * FilterSize);
                        varB[2] += Math.Pow((Convert.ToDouble(roivector3[2, i]) - avgB[2]), 2) / (FilterSize * FilterSize);
                        varB[3] += Math.Pow((Convert.ToDouble(roivector4[2, i]) - avgB[3]), 2) / (FilterSize * FilterSize);

                    }

                    int minIndexR = System.Array.IndexOf(varR, varR.Min());
                    int minIndexG = System.Array.IndexOf(varG, varG.Min());
                    int minIndexB = System.Array.IndexOf(varB, varB.Min());

                    newValueR = (int)avgR[minIndexR];

                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    newValueG = (int)avgG[minIndexG];

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    newValueB = (int)avgB[minIndexB];

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));
                }
            }

            return image2;
        }

        /// <summary>
        /// Tilt shift filtration
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Tilt shifted image</returns>
        public Bitmap TiltShift(Bitmap OriginalImage)
        {
            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            Bitmap tilt = new Bitmap(M, N);

            int N1 = (int)(N / 2);
            int N2 = (int)(N1 + N1 / 2);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j >= N1 && j <= N2)
                    {
                        tilt.SetPixel(i, j, OriginalImage.GetPixel(i, j));
                    }
                    else if (j < N1)
                    {
                        Double sigma = 0.1 + (6 - 0.1) * Convert.ToDouble(N1 - j) / Convert.ToDouble(N1);

                        List<Double> Filter = new List<double>();

                        for (int k = 0; k < 1000; k++)
                        {
                            Double K = Convert.ToDouble(k);
                            Double gauss = (1 / (Math.Sqrt(2 * Math.PI) * sigma)) * Math.Exp(-K * K / (2 * sigma * sigma));

                            if (gauss < 0.003)
                            {
                                break;
                            }
                            else
                            {
                                Filter.Add(gauss);
                            }
                        }

                        Double licznikR = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).R);
                        Double licznikG = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).G);
                        Double licznikB = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).B);

                        Double mianownik = Filter[0];

                        for (int a = 1; a < Filter.Count; a++)
                        {

                            mianownik += 2 * Filter[a];

                        }

                        for (int b = 1; b < Filter.Count; b++)
                        {

                            int x = i;
                            int y1 = j - b;
                            int y2 = j + b;

                            if (y1 < 0)
                            {
                                y1 = Math.Abs(y1);
                            }
                            else if (y2 >= N)
                            {
                                y2 = y2 + b - N + 1;
                            }
                            else
                            {

                                licznikR += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).R) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).R));
                                licznikG += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).G) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).G));
                                licznikB += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).B) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).B));

                            }

                        }

                        int newR = (int)(licznikR / mianownik);
                        int newG = (int)(licznikG / mianownik);
                        int newB = (int)(licznikB / mianownik);

                        if (newR > 255) newR = 255; if (newR < 0) newR = 0;
                        if (newG > 255) newG = 255; if (newG < 0) newG = 0;
                        if (newB > 255) newB = 255; if (newB < 0) newB = 0;

                        tilt.SetPixel(i, j, Color.FromArgb(255, newR, newG, newB));

                    }
                    else if (j > N2)
                    {
                        Double sigma = 0.1 + (6 - 0.1) * Convert.ToDouble(j - N2) / Convert.ToDouble(N1);

                        List<Double> Filter = new List<double>();

                        for (int k = 0; k < 1000; k++)
                        {
                            Double K = Convert.ToDouble(k);
                            Double gauss = (1 / (Math.Sqrt(2 * Math.PI) * sigma)) * Math.Exp(-K * K / (2 * sigma * sigma));

                            if (gauss < 0.003)
                            {
                                break;
                            }
                            else
                            {
                                Filter.Add(gauss);
                            }
                        }


                        Double licznikR = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).R);
                        Double licznikG = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).G);
                        Double licznikB = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).B);

                        Double mianownik = Filter[0];

                        for (int a = 1; a < Filter.Count; a++)
                        {

                            mianownik += 2 * Filter[a];

                        }

                        for (int b = 1; b < Filter.Count; b++)
                        {

                            int x = i;
                            int y1 = j - b;
                            int y2 = j + b;

                            if (y1 < 0)
                            {
                                y1 = Math.Abs(y1);
                            }
                            else if (y2 >= N)
                            {
                                y2 = y2 + b - N + 1;
                            }
                            else
                            {

                                licznikR += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).R) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).R));
                                licznikG += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).G) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).G));
                                licznikB += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).B) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).B));

                            }

                        }

                        int newR = (int)(licznikR / mianownik);
                        int newG = (int)(licznikG / mianownik);
                        int newB = (int)(licznikB / mianownik);

                        if (newR > 255) newR = 255; if (newR < 0) newR = 0;
                        if (newG > 255) newG = 255; if (newG < 0) newG = 0;
                        if (newB > 255) newB = 255; if (newB < 0) newB = 0;

                        tilt.SetPixel(i, j, Color.FromArgb(255, newR, newG, newB));
                    }
                }
            }



            return tilt;
        }

        /// <summary>
        /// Image bluring
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="X">Horizontal coordinate</param>
        /// <param name="Y">Vertical coordinate</param>
        /// <param name="r">Sharp region radius</param>
        /// <returns>Blurred image</returns>
        public Bitmap Blurring(Bitmap OriginalImage, int X, int Y, Double r)
        {
            int M = OriginalImage.Width;
            int N = OriginalImage.Height;

            if (X < 0 || X >= M || Y < 0 || Y >= N)
            {
                throw new Exception("Center of sharp region must be in dimensions of image");
            }

            Bitmap blur = new Bitmap(M, N);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    Double H = Math.Abs(Convert.ToDouble(i) - Convert.ToDouble(X));
                    Double V = Math.Abs(Convert.ToDouble(j) - Convert.ToDouble(Y));
                    Double R = Math.Sqrt(H * H + V * V);

                    if (R <= r)
                    {
                        blur.SetPixel(i, j, OriginalImage.GetPixel(i, j));
                    }
                    else
                    {
                        Double sigma = 0.1 + (6 - 0.1) * Convert.ToDouble(R) / Convert.ToDouble(2 * r);

                        List<Double> Filter = new List<double>();

                        for (int k = 0; k < 1000; k++)
                        {
                            Double K = Convert.ToDouble(k);
                            Double gauss = (1 / (Math.Sqrt(2 * Math.PI) * sigma)) * Math.Exp(-K * K / (2 * sigma * sigma));

                            if (gauss < 0.003)
                            {
                                break;
                            }
                            else
                            {
                                Filter.Add(gauss);
                            }
                        }


                        Double licznikR = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).R);
                        Double licznikG = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).G);
                        Double licznikB = Filter[0] * Convert.ToDouble(OriginalImage.GetPixel(i, j).B);

                        Double mianownik = Filter[0];

                        for (int a = 1; a < Filter.Count; a++)
                        {

                            mianownik += 2 * Filter[a];

                        }

                        for (int b = 1; b < Filter.Count; b++)
                        {

                            int x = i;
                            int y1 = j - b;
                            int y2 = j + b;

                            if (y1 < 0)
                            {
                                y1 = Math.Abs(y1);
                            }
                            else if (y2 >= N)
                            {
                                y2 = y2 + b - N + 1;
                            }
                            else
                            {

                                licznikR += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).R) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).R));
                                licznikG += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).G) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).G));
                                licznikB += Filter[b] * (Convert.ToDouble(OriginalImage.GetPixel(i, y1).B) + Convert.ToDouble(OriginalImage.GetPixel(i, y2).B));

                            }

                        }

                        int newR = (int)(licznikR / mianownik);
                        int newG = (int)(licznikG / mianownik);
                        int newB = (int)(licznikB / mianownik);

                        if (newR > 255) newR = 255; if (newR < 0) newR = 0;
                        if (newG > 255) newG = 255; if (newG < 0) newG = 0;
                        if (newB > 255) newB = 255; if (newB < 0) newB = 0;

                        blur.SetPixel(i, j, Color.FromArgb(255, newR, newG, newB));
                    }

                }
            }



            return blur;
        }

        /// <summary>
        /// Oil paint filtration
        /// </summary>
        /// <param name="OriginalImage">original ARGB image</param>
        /// <param name="R">Radius of oil paint algorithm</param>
        /// <param name="Level">Available levels of intensity</param>
        /// <returns>Oil paint filtred image</returns>
        public Bitmap OilPaint(Bitmap OriginalImage, int R, int Level)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            if (Level < 1 || Level > 255)
            {
                throw new Exception("Available intensity levels must be between 1 and 255");
            }

            if (R % 2 == 0)
            {
                throw new Exception("Filter mask dimension must be odd.");
            }

            if (R < 3)
            {
                throw new Exception("Filter mask dimension must be greater or equal 3.");
            }

            int range = (int)Math.Floor(Convert.ToDouble(R / 2));

            for (int m = range; m < image.Width - range; m++)
            {
                for (int n = range; n < image.Height - range; n++)
                {

                    Double[,,] roi = new Double[3, R, R];

                    int tmpi = 0;
                    int tmpj = 0;

                    int newValueR = 0;
                    int newValueG = 0;
                    int newValueB = 0;

                    for (int i = m - range; i < m + range + 1; i++)
                    {
                        for (int j = n - range; j < n + range + 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            Double pR = Convert.ToDouble(pixel.R);
                            Double pG = Convert.ToDouble(pixel.G);
                            Double pB = Convert.ToDouble(pixel.B);

                            roi[0, tmpi, tmpj] = (int)pR;
                            roi[1, tmpi, tmpj] = (int)pG;
                            roi[2, tmpi, tmpj] = (int)pB;

                            tmpj++;
                        }

                        tmpi++;
                        tmpj = 0;
                    }

                    int[] avgR = new int[256];
                    int[] avgG = new int[256];
                    int[] avgB = new int[256];
                    int[] intCnt = new int[256];

                    for (int k = 0; k < R; k++)
                    {
                        for (int l = 0; l < R; l++)
                        {
                            int intensity = (int)(((roi[0, k, l] + roi[1, k, l] + roi[2, k, l]) / 3) * Convert.ToDouble(Level) / 255);
                            intCnt[intensity]++;
                            avgR[intensity] += (int)roi[0, k, l];
                            avgG[intensity] += (int)roi[1, k, l];
                            avgB[intensity] += (int)roi[2, k, l];


                        }
                    }

                    int maxCur = 0;
                    int maxIndex = 0;

                    for (int a = 0; a < 256; a++)
                    {
                        if (intCnt[a] > maxCur)
                        {
                            maxCur = intCnt[a];
                            maxIndex = a;
                        }
                    }

                    newValueR = avgR[maxIndex] / maxCur;
                    newValueG = avgG[maxIndex] / maxCur;
                    newValueB = avgB[maxIndex] / maxCur;


                    if (newValueR > 255) newValueR = 255;
                    if (newValueR < 0) newValueR = 0;

                    if (newValueG > 255) newValueG = 255;
                    if (newValueG < 0) newValueG = 0;

                    if (newValueB > 255) newValueB = 255;
                    if (newValueB < 0) newValueB = 0;

                    image2.SetPixel(m, n, Color.FromArgb(255, newValueR, newValueG, newValueB));

                }
            }

            return image2;

        }

        /// <summary>
        /// Cartoon effect received by combining oil paint algorithm and Sobel edge detecting
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="R">Radius of oil paint algorithm</param>
        /// <param name="Level">Available levels of intensity</param>
        /// <param name="InverseThreshold">Inverse threshold</param>
        /// <returns>Cartoon effect result</returns>
        public Bitmap Cartoon(Bitmap OriginalImage, int R, int Level, int InverseThreshold)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            Bitmap oilpaint = this.OilPaint(image, R, Level);
            Bitmap edge = this.ToBlackwhiteInverse(this.ImageSobelFilterGS(image), InverseThreshold);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    if (edge.GetPixel(i, j).R == 255)
                    {
                        image2.SetPixel(i, j, oilpaint.GetPixel(i, j));
                    }
                    else
                    {
                        image2.SetPixel(i, j, edge.GetPixel(i, j));
                    }

                }
            }

            return image2;
        }

        /// <summary>
        /// Cartoon effect received by combining oil paint algorithm and edge detecting
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <param name="R">Radius of oil paint algorithm</param>
        /// <param name="Level">Available levels of intensity</param>
        /// <param name="InverseThreshold">Inverse threshold</param>
        /// <param name="EdgeFilter">Edge detecting mask</param>
        /// <returns>Cartoon effect result</returns>
        public Bitmap Cartoon(Bitmap OriginalImage, int R, int Level, int InverseThreshold, int[,] EdgeFilter)
        {
            Bitmap image = OriginalImage;
            Bitmap image2 = new Bitmap(image.Width, image.Height);

            Bitmap oilpaint = this.OilPaint(image, R, Level);
            Bitmap edge = this.ToBlackwhiteInverse(this.ImageFilterGS(image, EdgeFilter), InverseThreshold);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    if (edge.GetPixel(i, j).R == 255)
                    {
                        image2.SetPixel(i, j, oilpaint.GetPixel(i, j));
                    }
                    else
                    {
                        image2.SetPixel(i, j, edge.GetPixel(i, j));
                    }

                }
            }

            return image2;
        }

        /// <summary>
        /// Charcoal sketch effect received by combining median filtration with mask size of 5, Sobel edge detecting, image inversion on point 80
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Sketch effect image</returns>
        public Bitmap SketchCharcoal(Bitmap OriginalImage)
        {
            Bitmap image = this.ImageMedianFilterGS(OriginalImage, 5);

            image = this.ImageSobelFilterGS(image);

            image = this.InverseImage(image, 80);

            image = this.ImageMedianFilterGS(image, 5);

            return image;

        }

        /// <summary>
        /// Pen sketch effect received by combining laplace edge detecting, black and white transformation with inversion on point 35 and SDROM filter to eliminate smaller artefacts
        /// </summary>
        /// <param name="OriginalImage">Original ARGB image</param>
        /// <returns>Sketch effect image</returns>
        public Bitmap Sketch(Bitmap OriginalImage)
        {
            Bitmap image = OriginalImage;

            image = this.ImageFilterGS(image, LaplaceF1());

            image = this.ToBlackwhiteInverse(image, 35);

            image = this.ImageSDROMFilterGS(image);

            return image;

        }

    }
}
