using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistDigits.Models
{
    public class GradientDescentSeries
    {
        private List<DataPoint> _dataPoints;

        public GradientDescentSeries(double initialValue)
        {
            _dataPoints = new List<DataPoint>();
            _dataPoints.Add(new DataPoint(0, initialValue));
        }

        public void Add(double val)
        {
            _dataPoints.Add(new DataPoint(_dataPoints.Count, val));
        }

        public List<DataPoint> Points {
            get
            {
                return _dataPoints;
            }
        }

    }
}
