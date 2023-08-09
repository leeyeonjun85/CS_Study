using DevExpress.Xpo.Logger.Transport;
using SolaceSystems.Solclient.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Solace_DX_WinForms
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string serverIP { get; set; }
        string vpnName { get; set; }
        string userName { get; set; }
        string passWord { get; set; }

        const int DefaultReconnectRetries = 3;
        const int TotalMessages = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serverIP = tbServer.Text;
            vpnName = tbVPN.Text;
            userName = tbUserName.Text;
            passWord = tbUserPassword.Text;

            IContext context = ContextFactory.Instance.CreateContext(new ContextProperties(), null);

            // Create session properties
            SessionProperties sessionProps = new SessionProperties()
            {
                Host = serverIP,
                VPNName = vpnName,
                UserName = userName,
                Password = passWord,
                ReconnectRetries = DefaultReconnectRetries
            };

            ISession session = context.CreateSession(sessionProps, null, null);

            ReturnCode returnCode = session.Connect();



            returnCode == ReturnCode.SOLCLIENT_OK
        }
    }
}
