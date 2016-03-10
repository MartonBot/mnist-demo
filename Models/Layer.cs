using MathNet.Numerics.LinearAlgebra;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<double>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;
using Mb = MathNet.Numerics.LinearAlgebra.MatrixBuilder<double>;
using Vb = MathNet.Numerics.LinearAlgebra.VectorBuilder<double>;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits.Models
{
    public class Layer
    {
        private static Mb _M = Mat.Build;
        private static Vb _V = Vec.Build;

        private Mat _weights;

        public Mat Weights { get { return _weights; } }

        public Layer(int weightsRows, int weightsColumns)
        {
            _weights = _M.Random(weightsRows, weightsColumns);
        }

    }

}
