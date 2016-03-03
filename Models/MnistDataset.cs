using MathNet.Numerics.LinearAlgebra;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<int>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<int>;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MnistDigits
{
    public class MnistDataset
    {
        private static MatrixBuilder<int> _M = Mat.Build;
        private static VectorBuilder<int> _V = Vec.Build;
        private static Func<string, int> Int = (x) => int.Parse(x);

        public Mat Features
        {
            get
            {
                return _data.SubMatrix(0, M, 1, N);
            }
        }

        public Vec Target
        {
            get
            {
                return _data.Column(0);
            }
        }

        /// <summary>
        /// The number of samples
        /// </summary>
        public int M
        {
            get
            {
                return _data.RowCount;
            }
        }

        /// <summary>
        /// The number of features
        /// </summary>
        public int N
        {
            get
            {
                return _data.ColumnCount - 1;
            }
        }

        private Mat _data;

        /// <summary>
        /// Returns a matrix containing the samples in rows and the target values in the first column
        /// </summary>
        public Mat Data { get { return _data; } }

        public MnistDataset(string csvFilePath)
        {
            
            var lines = new List<int[]>();

            using (var sr = new StreamReader(csvFilePath))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine().Split(',').Select(Int).ToArray());
                }
            }

            _data = Mat.Build.DenseOfRowArrays(lines.ToArray());

        }

        /// <summary>
        /// The feature vector at <paramref name="rowIndex"/>
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public Vec this[int rowIndex]
        {
            get
            {
                return Features.Row(rowIndex);
            }
            set
            {
                Features.SetRow(rowIndex, value);
            }
        }

    }
}
