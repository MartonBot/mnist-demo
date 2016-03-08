using MathNet.Numerics.LinearAlgebra;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<float>;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits.Models
{
    public interface Hypothesis
    {
        float Value(Vec sample);
    }
}
