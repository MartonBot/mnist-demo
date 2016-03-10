using MnistDigits.Util;
using Models.MnistDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vb = MathNet.Numerics.LinearAlgebra.VectorBuilder<double>;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<double>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;

namespace MnistDigits.Models
{
    public class LogisticRegressionModel
    {
        private static Vb _V = Vec.Build;

        private Mat _X;
        private Vec _Y;
        private Vec _theta;
        private double _alpha = 1;

        public Vec Theta {
            get
            {
                return _theta;
            }
            set
            {
                _theta = value;
            }
        }

        public double Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
            }
        }

        public LogisticRegressionModel(MnistDataset trainingSet)
        {
            _X = trainingSet.Features;
            _Y = trainingSet.Target;
            _theta = _V.Dense(_X.ColumnCount);
        }

        public double Cost()
        {
            Vec h = _X.Multiply(_theta).Sigmoid();
            Vec c = - (Vec.op_DotMultiply(_Y, h.Log()) + Vec.op_DotMultiply((1 - _Y), (1 - h).Log()));
            return (1 / c.Count) * c.Sum();
        }

        public Vec CostGradient()
        {
            Vec diff = _X.Multiply(_theta) - _Y;
            return _X.Transpose().Multiply(diff.Sigmoid());
        }

        public Vec Predict(Mat samples)
        {
            return samples.Multiply(_theta).Sigmoid();
        }

        public void GradientDescentStep()
        {
            _theta -= _alpha * CostGradient();
        }

    }
}
