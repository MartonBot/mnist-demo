﻿using System;
using MathNet.Numerics.LinearAlgebra;
using Mat = MathNet.Numerics.LinearAlgebra.Matrix<double>;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;
using Mb = MathNet.Numerics.LinearAlgebra.MatrixBuilder<double>;
using Vb = MathNet.Numerics.LinearAlgebra.VectorBuilder<double>;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MnistDigits.Models;

namespace Models.MnistDigits
{
    public class MnistDataset
    {
        private static Mb _M = Mat.Build;
        private static Vb _V = Vec.Build;
        private static Func<string, double> ToDouble = (x) => double.Parse(x);
        private static Func<double, int> ToInt = (x) => (int)x;

        private Mat _data;

        /// <summary>
        /// Returns a matrix containing the samples in rows and the target values in the first column
        /// </summary>
        public Mat Data { get { return _data; } }

        public Mat FeaturesWithBias
        {
            get
            {
                return (_data.SubMatrix(0, M, 1, N) / 255.0).InsertColumn(0, BiasColumn);
            }
        }

        public Mat Features
        {
            get
            {
                return (_data.SubMatrix(0, M, 1, N) / 255.0);
            }
        }

        public Vec IntTarget
        {
            get
            {
                return _data.Column(0);
            }
        }

        public Mat DigitsTarget {
            get
            {
                var intTarget = IntTarget;
                Vec[] targetVectors = new Vec[10];
                for (int i = 0; i < 10; i++)
                {
                    targetVectors[i] = IntTarget.Map(x => (int)x == i ? 1.0 : 0.0);
                }
                return _M.DenseOfColumnVectors(targetVectors);
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

        public MnistDataset(string csvFilePath)
        {
            
            var lines = new List<double[]>();

            using (var sr = new StreamReader(csvFilePath))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine().Split(',').Select(ToDouble).ToArray());
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

        public List<MnistSample> Samples
        {
            get
            {
                return _data.EnumerateRows().Select(x => new MnistSample(x)).ToList();
            }
        }

        private Vec BiasColumn
        {
            get
            {
                return _V.Dense(_data.RowCount, 1.0);
            }
        }

    }
}
