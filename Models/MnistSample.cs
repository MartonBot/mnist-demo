using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;

namespace MnistDigits.Models
{
    public class MnistSample
    {

        private static int width = 28;
        private static int height = 28;
        private static int bpp = 8; //  grayscale

        private Vec _intFeatures;
        private int _label;
        private Bitmap _bitmap = null;

        public MnistSample(Vec row)
        {
            if (row.Count != width * height + 1)
            {
                string message = string.Format("The vector provided is not the right size ({0}x{1}+1) for an MNIST sample", width, height);
                throw new ArgumentException(message, nameof(row));
            }

            _label = (int)row[0];

            _intFeatures = row.SubVector(1, row.Count - 1);

        }

        public string Label
        {
            get
            {
                return string.Format("{0}", _label);
            }
        }

        public Vec Features
        {
            get
            {
                return _intFeatures;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                if (_bitmap == null)
                {
                    _bitmap = ToBitmap();
                }
                return _bitmap;
            }
        }

        public string FeaturesString
        {
            get
            {
                return string.Join(" ", _intFeatures);
            }
        }

        private Bitmap ToBitmap()
        {
            if (_intFeatures.Count != width * height)
            {
                string message = string.Format("This sample doesn't have the right number of features ({0}x{1}) to represent an MNIST image", width, height);
                throw new InvalidOperationException(message);
            }
            Bitmap bmp = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int i = ((y * width) + x);
                    if (bpp == 8) // grayscale
                    {
                        int level = (int)_intFeatures[i];
                        Color color = Color.FromArgb(level, level, level);
                        bmp.SetPixel(x, y, color);
                    }

                }
            }
            return bmp;
        }

    }
}
