namespace Solace_Sub_DX_WinForms
{
    partial class SubForm
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
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            btnSubStop = new DevExpress.XtraEditors.SimpleButton();
            btnSubStart = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tbPassword = new DevExpress.XtraEditors.TextEdit();
            tbName = new DevExpress.XtraEditors.TextEdit();
            tbVPN = new DevExpress.XtraEditors.TextEdit();
            tbServer = new DevExpress.XtraEditors.TextEdit();
            btnConnect = new DevExpress.XtraEditors.SimpleButton();
            lbLog = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVPN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbServer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lbLog).BeginInit();
            SuspendLayout();
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F) });
            tablePanel1.Controls.Add(btnSubStop);
            tablePanel1.Controls.Add(btnSubStart);
            tablePanel1.Controls.Add(labelControl4);
            tablePanel1.Controls.Add(labelControl3);
            tablePanel1.Controls.Add(labelControl2);
            tablePanel1.Controls.Add(labelControl1);
            tablePanel1.Controls.Add(tbPassword);
            tablePanel1.Controls.Add(tbName);
            tablePanel1.Controls.Add(tbVPN);
            tablePanel1.Controls.Add(tbServer);
            tablePanel1.Controls.Add(btnConnect);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel1.Size = new System.Drawing.Size(798, 103);
            tablePanel1.TabIndex = 0;
            tablePanel1.UseSkinIndents = true;
            // 
            // btnSubStop
            // 
            btnSubStop.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubStop.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnSubStop, 5);
            btnSubStop.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSubStop.Location = new System.Drawing.Point(711, 53);
            btnSubStop.Name = "btnSubStop";
            tablePanel1.SetRow(btnSubStop, 1);
            btnSubStop.Size = new System.Drawing.Size(74, 37);
            btnSubStop.TabIndex = 12;
            btnSubStop.Text = "Stop";
            btnSubStop.Click += btnSubStop_Click;
            // 
            // btnSubStart
            // 
            btnSubStart.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubStart.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnSubStart, 4);
            btnSubStart.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSubStart.Location = new System.Drawing.Point(634, 53);
            btnSubStart.Name = "btnSubStart";
            tablePanel1.SetRow(btnSubStart, 1);
            btnSubStart.Size = new System.Drawing.Size(74, 37);
            btnSubStart.TabIndex = 11;
            btnSubStart.Text = "Start";
            btnSubStart.Click += btnSubStart_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(labelControl4, 3);
            labelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl4.Location = new System.Drawing.Point(479, 30);
            labelControl4.Name = "labelControl4";
            tablePanel1.SetRow(labelControl4, 0);
            labelControl4.Size = new System.Drawing.Size(151, 19);
            labelControl4.TabIndex = 10;
            labelControl4.Text = "Password";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(labelControl3, 2);
            labelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl3.Location = new System.Drawing.Point(323, 30);
            labelControl3.Name = "labelControl3";
            tablePanel1.SetRow(labelControl3, 0);
            labelControl3.Size = new System.Drawing.Size(151, 19);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "User Name";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(labelControl2, 1);
            labelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl2.Location = new System.Drawing.Point(168, 30);
            labelControl2.Name = "labelControl2";
            tablePanel1.SetRow(labelControl2, 0);
            labelControl2.Size = new System.Drawing.Size(151, 19);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "VPN Name";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(labelControl1, 0);
            labelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl1.Location = new System.Drawing.Point(13, 30);
            labelControl1.Name = "labelControl1";
            tablePanel1.SetRow(labelControl1, 0);
            labelControl1.Size = new System.Drawing.Size(151, 19);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "Server IP";
            // 
            // tbPassword
            // 
            tablePanel1.SetColumn(tbPassword, 3);
            tbPassword.EditValue = "1234";
            tbPassword.Location = new System.Drawing.Point(479, 58);
            tbPassword.Name = "tbPassword";
            tbPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbPassword.Properties.Appearance.Options.UseFont = true;
            tablePanel1.SetRow(tbPassword, 1);
            tbPassword.Size = new System.Drawing.Size(151, 26);
            tbPassword.TabIndex = 6;
            // 
            // tbName
            // 
            tablePanel1.SetColumn(tbName, 2);
            tbName.EditValue = "testUser";
            tbName.Location = new System.Drawing.Point(323, 58);
            tbName.Name = "tbName";
            tbName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbName.Properties.Appearance.Options.UseFont = true;
            tablePanel1.SetRow(tbName, 1);
            tbName.Size = new System.Drawing.Size(151, 26);
            tbName.TabIndex = 5;
            // 
            // tbVPN
            // 
            tablePanel1.SetColumn(tbVPN, 1);
            tbVPN.EditValue = "testVPN";
            tbVPN.Location = new System.Drawing.Point(168, 58);
            tbVPN.Name = "tbVPN";
            tbVPN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbVPN.Properties.Appearance.Options.UseFont = true;
            tablePanel1.SetRow(tbVPN, 1);
            tbVPN.Size = new System.Drawing.Size(151, 26);
            tbVPN.TabIndex = 4;
            // 
            // tbServer
            // 
            tablePanel1.SetColumn(tbServer, 0);
            tbServer.EditValue = "192.168.10.124";
            tbServer.Location = new System.Drawing.Point(13, 58);
            tbServer.Name = "tbServer";
            tbServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbServer.Properties.Appearance.Options.UseFont = true;
            tablePanel1.SetRow(tbServer, 1);
            tbServer.Size = new System.Drawing.Size(151, 26);
            tbServer.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConnect.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnConnect, 4);
            tablePanel1.SetColumnSpan(btnConnect, 2);
            btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            btnConnect.Location = new System.Drawing.Point(634, 12);
            btnConnect.Name = "btnConnect";
            tablePanel1.SetRow(btnConnect, 0);
            btnConnect.Size = new System.Drawing.Size(151, 37);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // lbLog
            // 
            lbLog.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            lbLog.Appearance.Options.UseBackColor = true;
            lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            lbLog.Location = new System.Drawing.Point(0, 103);
            lbLog.Name = "lbLog";
            lbLog.Size = new System.Drawing.Size(798, 465);
            lbLog.TabIndex = 2;
            // 
            // SubForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 568);
            Controls.Add(lbLog);
            Controls.Add(tablePanel1);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "SubForm";
            Text = "Solace Pub/Sub";
            FormClosing += SubForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVPN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbServer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lbLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.ListBoxControl lbLog;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbPassword;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.TextEdit tbVPN;
        private DevExpress.XtraEditors.TextEdit tbServer;
        private DevExpress.XtraEditors.SimpleButton btnSubStart;
        private DevExpress.XtraEditors.SimpleButton btnSubStop;
    }
}

