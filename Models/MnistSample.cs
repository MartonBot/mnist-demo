using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits.Models
{
    public class MnistSample
    {

        private static int width = 28;
        private static int height = 28;
        private static int bpp = 8; //  grayscale

        private int[] _features;
        private int _label;
        private Bitmap _bitmap = null;

        public MnistSample(float[] array)
        {
            if (array.Length != width * height + 1)
            {
                string message = string.Format("The array of float provided is not the right size ({0}x{1}+1) for an MNIST sample", width, height);
                throw new ArgumentException(message, nameof(array));
            }
            
            float[] temp = new float[width * height];
            Array.Copy(array, 1, temp, 0, temp.Length);

            _label = (int)array[0];
            _features = temp.Select(x => (int)x).ToArray();

        }

        public MnistSample(int[] features, int label)
        {
            if (features.Length != width * height)
            {
                string message = string.Format("The array of int provided is not the right size ({0}x{1}) for an MNIST sample", width, height);
                throw new ArgumentException(message, nameof(features));
            }
            _features = features;
            _label = label;
        }

        public string Label
        {
            get
            {
                return string.Format("{0}", _label);
            }
        }

        public int[] Features
        {
            get
            {
                return _features;
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

        private Bitmap ToBitmap()
        {
            if (_features.Length != width * height)
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
                        int level = (int)_features[i];
                        Color color = Color.FromArgb(level, level, level);
                        bmp.SetPixel(x, y, color);
                    }

                }
            }
            return bmp;
        }
    }
}
