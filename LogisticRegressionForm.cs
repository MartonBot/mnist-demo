using MnistDigits.Models;
using Models.MnistDigits;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;
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
            _model = new LogisticRegressionModel(_dataset, 1);
            _gradientDescentSeries = new GradientDescentSeries(_model.CostsVector().Average());

            //
            var myModel = new PlotModel { Title = "Cost" };
            LineSeries s = new LineSeries();
            s.ItemsSource = _gradientDescentSeries.Points;
            myModel.Series.Add(s);

            gradientDescentPlotView.Model = myModel;

            ReevaluatePredictions();
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
            _gradientDescentSeries.Add(_model.CostsVector().Average());
            gradientDescentPlotView.InvalidatePlot(true);
            ReevaluatePredictions();
        }

        private void alphaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            ReevaluatePredictions();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _model.ResetHypothesis();
        }

        private void ReevaluatePredictions()
        {
            Vec actual = _dataset.IntTarget;
            Vec predicted = _model.Predict(_dataset.FeaturesWithBias);

            List<Tuple<int, int>> actualVsPredicted = new List<Tuple<int, int>>();


            for (int i = 0; i < actual.Count; i++)
            {
                actualVsPredicted.Add(new Tuple<int, int>((int)actual[i], (int)predicted[i]));
            }
            predictionResultsListBox.DataSource = actualVsPredicted;

            int matches = actualVsPredicted.Where(t => (t.Item1 == t.Item2)).Count();

            predictionsOutcomelabel.Text = string.Format("{0} matches out of {1} samples", matches, actual.Count);
        }
    }
}
