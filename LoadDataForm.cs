using Models.MnistDigits;
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
    public partial class LoadDataForm : Form
    {

        private MnistDataset _dataset;

        public LoadDataForm()
        {
            InitializeComponent();
            openCsvFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openCsvButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openCsvFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    _dataset = new MnistDataset(openCsvFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    datasetValidationLabel.Text = "Failed to load dataset";
                    return;
                }

                datasetValidationLabel.Text = "Dataset loaded successfully";

                samplesListBox.DataSource = _dataset.Samples;
            }
        }

        private void openCsvFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            
        }

    }
}
