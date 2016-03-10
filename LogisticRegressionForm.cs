using MnistDigits.Models;
using Models.MnistDigits;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnistDigits
{
    public partial class LogisticRegressionForm : Form
    {

        private MnistDataset _dataset;
        private LogisticRegressionModel _model;
        private GradientDescentSeries _gradientDescentSeries;

        public LogisticRegressionForm(MnistDataset dataset)
        {
            InitializeComponent();
            _dataset = dataset;
            _model = new LogisticRegressionModel(_dataset);
            _gradientDescentSeries = new GradientDescentSeries(_model.Cost());

            //
            var myModel = new PlotModel { Title = "Cost" };
            LineSeries s = new LineSeries();
            s.ItemsSource = new GradientDescentSeries(8).Points;
            myModel.Series.Add(s);

            gradientDescentPlotView.Model = myModel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            _model.GradientDescentStep();
            _gradientDescentSeries.Add(_model.Cost());
            gradientDescentPlotView.InvalidatePlot(true);
        }
    }
}
