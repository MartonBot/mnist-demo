using MnistDigits.Util;
using Models.MnistDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vb = MathNet.Numerics.LinearAlgebra.VectorBuilder<double>;
using Mb = MathNet.Numerics.LinearAlgebra.MatrixBuilder<double>;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<double>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;

namespace MnistDigits.Models
{
    public class LogisticRegressionModel
    {
        private static Vb _V = Vec.Build;
        private static Mb _M = Mat.Build;

        /// <summary>
        /// The matrix of the training examples' features, in rows, including the bias.
        /// </summary>
        private Mat _X;

        /// <summary>
        /// The targets matrix, each column representing a digit from 0 to 9.
        /// </summary>
        private Mat _Y;

        /// <summary>
        /// The parameter vector Theta to optimise.
        /// </summary>
        private Mat _thetas;

        /// <summary>
        /// The step to take during Gradient Descent.
        /// </summary>
        private double _alpha = 1;

        private static Func<double, double, double> _logisticCost = (x, y) => -((int)y == 1? Math.Log(x) : Math.Log(1.0 - x));
        private static Func<double, double> _sigmoid = t => (1.0 / (1.0 + Math.Exp(-t)));

        public Mat Thetas {
            get
            {
                return _thetas;
            }
            set
            {
                _thetas = value;
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

        public LogisticRegressionModel(MnistDataset trainingSet, int digit)
        {
            _X = trainingSet.FeaturesWithBias;
            _Y = trainingSet.DigitsTarget;
            _thetas = _M.Random(_X.ColumnCount, _Y.ColumnCount);
        }

        /// <summary>
        /// Returns a vector of length 10 where each element represents the dataset's cost for a digit from 0 to 9.
        /// </summary>
        /// <returns></returns>
        public Vec CostsVector()
        {
            // m x 10
            Mat hx = _X.Multiply(_thetas).Map(_sigmoid);

            // m x 10
            Mat costsMatrix = _M.Dense(hx.RowCount, _thetas.ColumnCount);

            hx.Map2(_logisticCost, _Y, costsMatrix);

            // 1 x 10
            Vec costs = (1.0 / _X.RowCount) * costsMatrix.RowSums();

            return costs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Mat CostGradients()
        {
            Mat hx = _X.Multiply(_thetas).Map(_sigmoid);
            Mat diffMat = hx - _Y;
            Mat grads = (1.0 / _X.RowCount) * _X.Transpose().Multiply(diffMat);
            return grads;
        }

        /// <summary>
        /// Returns a vector containing the predictions for the supplied samples matrix (the values have to be interpreted as digits)
        /// </summary>
        /// <param name="samples"></param>
        /// <returns></returns>
        public Vec Predict(Mat samples)
        {
            return IndicesForMax(_X.Multiply(_thetas).Map(_sigmoid));
        }

        public void GradientDescentStep()
        {
            Mat toRemove = _alpha * CostGradients();
            _thetas = _thetas - toRemove;
        }

        private Vec IndicesForMax(Mat predictions)
        {
            Vec maxima = predictions.Column(0);
            Vec maxIndices = _V.Dense(predictions.RowCount);
            for (int index = 1; index < 10; index++)
            {
                Vec isGreater = maxima.Map2((a, b) => b > a ? 1 : 0, predictions.Column(index));
                maxIndices = isGreater.Map2((i, j) => (int)i == 1 ? index : j, maxIndices);
                maxima = maxima.Map2((a, b) => Math.Max(a, b), predictions.Column(index));
            }

            return maxIndices;
        }

        public void ResetHypothesis()
        {
            _thetas = _M.Random(_X.ColumnCount, _Y.ColumnCount);
        }

    }
}
