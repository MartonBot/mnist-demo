using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;

namespace MnistDigits.Util
{
    public static class VectorExtensions
    {

        private static Func<double, double> _sigmoid = t => (1.0 / (1.0 + Math.Exp(-t)));

        public static Vec Log(this Vec v)
        {
            return v.Map(Math.Log);
        }

        public static Vec Sigmoid(this Vec v)
        {
            return v.Map(_sigmoid);
        }

    }
}
