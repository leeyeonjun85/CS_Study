namespace Solace_DX_WinForms
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
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            tbUserPassword = new DevExpress.XtraEditors.TextEdit();
            tbUserName = new DevExpress.XtraEditors.TextEdit();
            tbVPN = new DevExpress.XtraEditors.TextEdit();
            tbServer = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            btnConnect = new DevExpress.XtraEditors.SimpleButton();
            btnConfig = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            tbLog = new System.Windows.Forms.TextBox();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUserPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVPN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbServer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stackPanel2).BeginInit();
            SuspendLayout();
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F) });
            tablePanel1.Controls.Add(labelControl4);
            tablePanel1.Controls.Add(labelControl3);
            tablePanel1.Controls.Add(labelControl2);
            tablePanel1.Controls.Add(tbUserPassword);
            tablePanel1.Controls.Add(tbUserName);
            tablePanel1.Controls.Add(tbVPN);
            tablePanel1.Controls.Add(tbServer);
            tablePanel1.Controls.Add(labelControl1);
            tablePanel1.Location = new System.Drawing.Point(13, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 53F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            tablePanel1.Size = new System.Drawing.Size(569, 140);
            tablePanel1.TabIndex = 2;
            tablePanel1.UseSkinIndents = true;
            // 
            // labelControl4
            // 
            tablePanel1.SetColumn(labelControl4, 3);
            labelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl4.Location = new System.Drawing.Point(423, 47);
            labelControl4.Name = "labelControl4";
            tablePanel1.SetRow(labelControl4, 0);
            labelControl4.Size = new System.Drawing.Size(133, 14);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "User Password";
            // 
            // labelControl3
            // 
            tablePanel1.SetColumn(labelControl3, 2);
            labelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl3.Location = new System.Drawing.Point(287, 47);
            labelControl3.Name = "labelControl3";
            tablePanel1.SetRow(labelControl3, 0);
            labelControl3.Size = new System.Drawing.Size(133, 14);
            labelControl3.TabIndex = 6;
            labelControl3.Text = "User Name";
            // 
            // labelControl2
            // 
            tablePanel1.SetColumn(labelControl2, 1);
            labelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl2.Location = new System.Drawing.Point(150, 47);
            labelControl2.Name = "labelControl2";
            tablePanel1.SetRow(labelControl2, 0);
            labelControl2.Size = new System.Drawing.Size(133, 14);
            labelControl2.TabIndex = 5;
            labelControl2.Text = "VPN Name";
            // 
            // tbUserPassword
            // 
            tablePanel1.SetColumn(tbUserPassword, 3);
            tbUserPassword.Dock = System.Windows.Forms.DockStyle.Top;
            tbUserPassword.EditValue = "1234";
            tbUserPassword.Location = new System.Drawing.Point(423, 65);
            tbUserPassword.Name = "tbUserPassword";
            tablePanel1.SetRow(tbUserPassword, 1);
            tbUserPassword.Size = new System.Drawing.Size(133, 20);
            tbUserPassword.TabIndex = 4;
            // 
            // tbUserName
            // 
            tablePanel1.SetColumn(tbUserName, 2);
            tbUserName.Dock = System.Windows.Forms.DockStyle.Top;
            tbUserName.EditValue = "testUser";
            tbUserName.Location = new System.Drawing.Point(287, 65);
            tbUserName.Name = "tbUserName";
            tablePanel1.SetRow(tbUserName, 1);
            tbUserName.Size = new System.Drawing.Size(133, 20);
            tbUserName.TabIndex = 3;
            // 
            // tbVPN
            // 
            tablePanel1.SetColumn(tbVPN, 1);
            tbVPN.Dock = System.Windows.Forms.DockStyle.Top;
            tbVPN.EditValue = "testVPN";
            tbVPN.Location = new System.Drawing.Point(150, 65);
            tbVPN.Name = "tbVPN";
            tablePanel1.SetRow(tbVPN, 1);
            tbVPN.Size = new System.Drawing.Size(133, 20);
            tbVPN.TabIndex = 2;
            // 
            // tbServer
            // 
            tablePanel1.SetColumn(tbServer, 0);
            tbServer.Dock = System.Windows.Forms.DockStyle.Top;
            tbServer.EditValue = "192.168.10.124";
            tbServer.Location = new System.Drawing.Point(13, 65);
            tbServer.Name = "tbServer";
            tablePanel1.SetRow(tbServer, 1);
            tbServer.Size = new System.Drawing.Size(133, 20);
            tbServer.TabIndex = 1;
            // 
            // labelControl1
            // 
            tablePanel1.SetColumn(labelControl1, 0);
            labelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelControl1.Location = new System.Drawing.Point(13, 47);
            labelControl1.Name = "labelControl1";
            tablePanel1.SetRow(labelControl1, 0);
            labelControl1.Size = new System.Drawing.Size(133, 14);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Server IP";
            // 
            // tablePanel2
            // 
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel2.Controls.Add(btnConnect);
            tablePanel2.Controls.Add(btnConfig);
            tablePanel2.Controls.Add(btnSave);
            tablePanel2.Location = new System.Drawing.Point(586, 0);
            tablePanel2.Name = "tablePanel2";
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
            tablePanel2.Size = new System.Drawing.Size(197, 140);
            tablePanel2.TabIndex = 3;
            tablePanel2.UseSkinIndents = true;
            // 
            // btnConnect
            // 
            tablePanel2.SetColumn(btnConnect, 1);
            btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            btnConnect.Location = new System.Drawing.Point(101, 12);
            btnConnect.Name = "btnConnect";
            tablePanel2.SetRow(btnConnect, 0);
            tablePanel2.SetRowSpan(btnConnect, 2);
            btnConnect.Size = new System.Drawing.Size(84, 115);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // btnConfig
            // 
            tablePanel2.SetColumn(btnConfig, 0);
            btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            btnConfig.Location = new System.Drawing.Point(13, 72);
            btnConfig.Name = "btnConfig";
            tablePanel2.SetRow(btnConfig, 1);
            btnConfig.Size = new System.Drawing.Size(84, 55);
            btnConfig.TabIndex = 1;
            btnConfig.Text = "Config";
            // 
            // btnSave
            // 
            tablePanel2.SetColumn(btnSave, 0);
            btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSave.Location = new System.Drawing.Point(13, 12);
            btnSave.Name = "btnSave";
            tablePanel2.SetRow(btnSave, 0);
            btnSave.Size = new System.Drawing.Size(84, 56);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            // 
            // tbLog
            // 
            tbLog.BackColor = System.Drawing.SystemColors.Info;
            tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            tbLog.Location = new System.Drawing.Point(0, 271);
            tbLog.Multiline = true;
            tbLog.Name = "tbLog";
            tbLog.Size = new System.Drawing.Size(798, 297);
            tbLog.TabIndex = 4;
            tbLog.Text = "=== Solace Log ===";
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(tablePanel1);
            stackPanel1.Controls.Add(tablePanel2);
            stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            stackPanel1.Location = new System.Drawing.Point(0, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new System.Drawing.Size(798, 140);
            stackPanel1.TabIndex = 5;
            stackPanel1.UseSkinIndents = true;
            // 
            // stackPanel2
            // 
            stackPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            stackPanel2.Location = new System.Drawing.Point(0, 140);
            stackPanel2.Name = "stackPanel2";
            stackPanel2.Size = new System.Drawing.Size(798, 131);
            stackPanel2.TabIndex = 6;
            stackPanel2.UseSkinIndents = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 568);
            Controls.Add(stackPanel2);
            Controls.Add(stackPanel1);
            Controls.Add(tbLog);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Solace - EDCore";
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbUserPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVPN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbServer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stackPanel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbUserPassword;
        private DevExpress.XtraEditors.TextEdit tbUserName;
        private DevExpress.XtraEditors.TextEdit tbVPN;
        private DevExpress.XtraEditors.TextEdit tbServer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.SimpleButton btnConfig;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox tbLog;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
    }
}

