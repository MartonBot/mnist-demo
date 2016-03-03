using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits
{
    internal static class ArrayExtensions
    {

        private static int width = 20;
        private static int height = 20;

        private static int bpp = 8; //  grayscale

        internal static Bitmap ToBitmap(this float[] array, int a)
        {
            Bitmap bmp = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int i = ((y * width) + x);
                    if (bpp == 8) // grayscale
                    {
                        int level = (int) array[i];
                        Color color = Color.FromArgb(level, level, level);
                        bmp.SetPixel(x, y, color);
                    }

                }
            }
            return null;
        }

    }
}
