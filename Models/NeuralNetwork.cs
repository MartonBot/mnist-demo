using System;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<double>;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits.Models
{
    public class NeuralNetwork
    {
        private Layer[] _layers;

        public Layer[] Layers { get; }

    }
}
