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
            button1 = new DevExpress.XtraEditors.SimpleButton();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Legend.LegendID = -1;
            chartControl1.Location = new System.Drawing.Point(394, 25);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new System.Drawing.Size(331, 262);
            chartControl1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 25);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "simpleButton1";
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Info;
            textBox1.Location = new System.Drawing.Point(93, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(295, 262);
            textBox1.TabIndex = 2;
            textBox1.Text = "== Text ==";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(737, 299);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(chartControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

