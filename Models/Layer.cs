using MathNet.Numerics.LinearAlgebra;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<float>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<float>;
using Mb = MathNet.Numerics.LinearAlgebra.MatrixBuilder<float>;
using Vb = MathNet.Numerics.LinearAlgebra.VectorBuilder<float>;
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

        private Matrix<float> weights;

        public Layer(int weightsRows, int weightsColumns)
        {
            weights = _M.Random(weightsRows, weightsColumns);
        }

    }

}
