using OxyPlot.WindowsForms;

namespace MnistDigits
{
    partial class LoadDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.datasetValidationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openCsvButton = new System.Windows.Forms.Button();
            this.samplesListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.featuresTextBox = new System.Windows.Forms.TextBox();
            this.digitPictureBox = new System.Windows.Forms.PictureBox();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logisticRegressionButton = new System.Windows.Forms.Button();
            this.neuralNetworkButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loading and Visualising the Dataset";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.datasetValidationLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.openCsvButton);
            this.splitContainer1.Panel1.Controls.Add(this.samplesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.neuralNetworkButton);
            this.splitContainer1.Panel2.Controls.Add(this.logisticRegressionButton);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.featuresTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.digitPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 474);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // datasetValidationLabel
            // 
            this.datasetValidationLabel.AutoSize = true;
            this.datasetValidationLabel.Location = new System.Drawing.Point(3, 29);
            this.datasetValidationLabel.Name = "datasetValidationLabel";
            this.datasetValidationLabel.Size = new System.Drawing.Size(58, 13);
            this.datasetValidationLabel.TabIndex = 3;
            this.datasetValidationLabel.Text = "--validation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No file selected";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openCsvButton
            // 
            this.openCsvButton.Location = new System.Drawing.Point(3, 3);
            this.openCsvButton.Name = "openCsvButton";
            this.openCsvButton.Size = new System.Drawing.Size(91, 23);
            this.openCsvButton.TabIndex = 1;
            this.openCsvButton.Text = "Open CSV file";
            this.openCsvButton.UseVisualStyleBackColor = true;
            this.openCsvButton.Click += new System.EventHandler(this.openCsvButton_Click);
            // 
            // samplesListBox
            // 
            this.samplesListBox.FormattingEnabled = true;
            this.samplesListBox.Location = new System.Drawing.Point(3, 53);
            this.samplesListBox.Name = "samplesListBox";
            this.samplesListBox.Size = new System.Drawing.Size(178, 420);
            this.samplesListBox.TabIndex = 0;
            this.samplesListBox.SelectedIndexChanged += new System.EventHandler(this.samplesListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(383, 193);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Datasets definitions TBW";
            // 
            // featuresTextBox
            // 
            this.featuresTextBox.Location = new System.Drawing.Point(177, 303);
            this.featuresTextBox.Multiline = true;
            this.featuresTextBox.Name = "featuresTextBox";
            this.featuresTextBox.ReadOnly = true;
            this.featuresTextBox.Size = new System.Drawing.Size(834, 168);
            this.featuresTextBox.TabIndex = 2;
            // 
            // digitPictureBox
            // 
            this.digitPictureBox.Location = new System.Drawing.Point(3, 303);
            this.digitPictureBox.Name = "digitPictureBox";
            this.digitPictureBox.Size = new System.Drawing.Size(168, 168);
            this.digitPictureBox.TabIndex = 0;
            this.digitPictureBox.TabStop = false;
            this.digitPictureBox.Click += new System.EventHandler(this.digitPictureBox_Click);
            // 
            // openCsvFileDialog
            // 
            this.openCsvFileDialog.FileName = "Open CSV File Dialog";
            this.openCsvFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openCsvFileDialog_FileOk);
            // 
            // logisticRegressionButton
            // 
            this.logisticRegressionButton.Location = new System.Drawing.Point(833, 208);
            this.logisticRegressionButton.Name = "logisticRegressionButton";
            this.logisticRegressionButton.Size = new System.Drawing.Size(128, 23);
            this.logisticRegressionButton.TabIndex = 4;
            this.logisticRegressionButton.Text = "Logistic Regression";
            this.logisticRegressionButton.UseVisualStyleBackColor = true;
            this.logisticRegressionButton.Click += new System.EventHandler(this.logisticRegressionButton_Click);
            // 
            // neuralNetworkButton
            // 
            this.neuralNetworkButton.Location = new System.Drawing.Point(833, 246);
            this.neuralNetworkButton.Name = "neuralNetworkButton";
            this.neuralNetworkButton.Size = new System.Drawing.Size(128, 23);
            this.neuralNetworkButton.TabIndex = 5;
            this.neuralNetworkButton.Text = "NeuralNetwork";
            this.neuralNetworkButton.UseVisualStyleBackColor = true;
            // 
            // LoadDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 517);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoadDataForm";
            this.Text = "LoadDataForm";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox samplesListBox;
        private System.Windows.Forms.OpenFileDialog openCsvFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCsvButton;
        private System.Windows.Forms.Label datasetValidationLabel;
        private System.Windows.Forms.PictureBox digitPictureBox;
        private System.Windows.Forms.TextBox featuresTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button logisticRegressionButton;
        private System.Windows.Forms.Button neuralNetworkButton;

    }
        
}