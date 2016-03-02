namespace MnistDigits
{
    partial class MainForm
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
            this.dataSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.fittingGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.evaluationGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSourceGroupBox
            // 
            this.dataSourceGroupBox.Location = new System.Drawing.Point(3, 3);
            this.dataSourceGroupBox.Name = "dataSourceGroupBox";
            this.dataSourceGroupBox.Size = new System.Drawing.Size(200, 100);
            this.dataSourceGroupBox.TabIndex = 0;
            this.dataSourceGroupBox.TabStop = false;
            this.dataSourceGroupBox.Text = "Data source";
            this.dataSourceGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Location = new System.Drawing.Point(209, 3);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(200, 100);
            this.selectionGroupBox.TabIndex = 1;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Selection";
            // 
            // fittingGroupBox
            // 
            this.fittingGroupBox.Location = new System.Drawing.Point(415, 3);
            this.fittingGroupBox.Name = "fittingGroupBox";
            this.fittingGroupBox.Size = new System.Drawing.Size(200, 100);
            this.fittingGroupBox.TabIndex = 2;
            this.fittingGroupBox.TabStop = false;
            this.fittingGroupBox.Text = "Fitting the data";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataSourceGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.selectionGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.fittingGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.evaluationGroupBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 289);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // evaluationGroupBox
            // 
            this.evaluationGroupBox.Location = new System.Drawing.Point(3, 109);
            this.evaluationGroupBox.Name = "evaluationGroupBox";
            this.evaluationGroupBox.Size = new System.Drawing.Size(200, 100);
            this.evaluationGroupBox.TabIndex = 3;
            this.evaluationGroupBox.TabStop = false;
            this.evaluationGroupBox.Text = "Evaluating the results";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 499);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MNIST Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataSourceGroupBox;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.GroupBox fittingGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox evaluationGroupBox;
    }
}

