namespace DX1
{
    partial class Form1
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
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Legend.LegendID = -1;
            chartControl1.Location = new System.Drawing.Point(147, 25);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new System.Drawing.Size(300, 200);
            chartControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(737, 299);
            Controls.Add(chartControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

