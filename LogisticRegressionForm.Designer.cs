using OxyPlot.WindowsForms;

namespace MnistDigits
{
    partial class LogisticRegressionForm
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
            this.runButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stepButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.rateLabel = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.gradientDescentPlotView = new OxyPlot.WindowsForms.PlotView();
            this.predictButton = new System.Windows.Forms.Button();
            this.predictionResultsListBox = new System.Windows.Forms.ListBox();
            this.predictionsOutcomelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.predictionsOutcomelabel);
            this.groupBox1.Controls.Add(this.predictionResultsListBox);
            this.groupBox1.Controls.Add(this.predictButton);
            this.groupBox1.Controls.Add(this.runButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stepButton);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.rateLabel);
            this.groupBox1.Controls.Add(this.alphaTextBox);
            this.groupBox1.Controls.Add(this.gradientDescentPlotView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logistic Regression";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(216, 102);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "steps";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Take";
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(25, 65);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 3;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(237, 26);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset Theta";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(22, 33);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Rate";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(63, 30);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphaTextBox.TabIndex = 0;
            this.alphaTextBox.TextChanged += new System.EventHandler(this.alphaTextBox_TextChanged);
            // 
            // gradientDescentPlotView
            // 
            this.gradientDescentPlotView.Location = new System.Drawing.Point(3, 131);
            this.gradientDescentPlotView.Name = "gradientDescentPlotView";
            this.gradientDescentPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.gradientDescentPlotView.Size = new System.Drawing.Size(782, 372);
            this.gradientDescentPlotView.TabIndex = 0;
            this.gradientDescentPlotView.Text = "plot1";
            this.gradientDescentPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.gradientDescentPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.gradientDescentPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(803, 26);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(75, 23);
            this.predictButton.TabIndex = 10;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // predictionResultsListBox
            // 
            this.predictionResultsListBox.FormattingEnabled = true;
            this.predictionResultsListBox.Location = new System.Drawing.Point(803, 131);
            this.predictionResultsListBox.Name = "predictionResultsListBox";
            this.predictionResultsListBox.Size = new System.Drawing.Size(371, 368);
            this.predictionResultsListBox.TabIndex = 11;
            // 
            // predictionsOutcomelabel
            // 
            this.predictionsOutcomelabel.AutoSize = true;
            this.predictionsOutcomelabel.Location = new System.Drawing.Point(885, 32);
            this.predictionsOutcomelabel.Name = "predictionsOutcomelabel";
            this.predictionsOutcomelabel.Size = new System.Drawing.Size(0, 13);
            this.predictionsOutcomelabel.TabIndex = 12;
            // 
            // LogisticRegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogisticRegressionForm";
            this.Text = "MNIST Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stepButton;
        private PlotView gradientDescentPlotView;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.ListBox predictionResultsListBox;
        private System.Windows.Forms.Label predictionsOutcomelabel;
    }
}

