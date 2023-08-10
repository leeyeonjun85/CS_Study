using DevExpress.XtraEditors;
using SolaceSystems.Solclient.Messaging;
using System.Text;
using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace Solace_PubSub_DX_WinForms
{
    public partial class PubForm : DevExpress.XtraEditors.XtraForm
    {
        const int ReconnectRetries = 3;

        private IContext context;
        private ISession session = null;

        public bool isCotext { get; set; } = false;
        public bool isSession { get; set; } = false;
        string Host { get; set; }
        string VPNName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        public PubForm()
        {
            InitializeComponent();

            // Initialize Solace Systems Messaging API with logging to console at Warning level
            ContextFactoryProperties cfp = new()
            {
                SolClientLogLevel = SolLogLevel.Warning
            };
            cfp.LogToConsoleError();
            ContextFactory.Instance.Init(cfp);

            btnConnect.Enabled = true;
            btnPub.Enabled = false;
        }

        private static void PublishMessage(ISession session, ListBoxControl lbLog, TextEdit tbSend)
        {
            // Create the message
            using (IMessage message = ContextFactory.Instance.CreateMessage())
            {
                message.Destination = ContextFactory.Instance.CreateTopic("tutorial/topic");
                // Create the message content as a binary attachment
                message.BinaryAttachment = Encoding.ASCII.GetBytes(tbSend.Text);
                lbLog.Items.Add($"Message content: {tbSend.Text}");

                // Publish the message to the topic on the Solace messaging router
                ReturnCode returnCode = session.Send(message);
                if (returnCode == ReturnCode.SOLCLIENT_OK)
                {
                    lbLog.Items.Add($"Done.");
                }
                else
                {
                    lbLog.Items.Add($"Publishing failed, return code: {returnCode}");
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Check input text
                Host = tbServer.Text; VPNName = tbVPN.Text;
                UserName = tbName.Text; Password = tbPassword.Text;
                if (Host == "" || VPNName == "" || UserName == "" || Password == "")
                {
                    MessageBox.Show("IP, VPN, 사용자이름, 비밀번호를 모두 입력하셔야합니다.", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Context must be created first
                context = ContextFactory.Instance.CreateContext(new ContextProperties(), null);

                // Create session properties
                SessionProperties sessionProps = new()
                {
                    Host = Host,
                    VPNName = VPNName,
                    UserName = UserName,
                    Password = Password,
                    ReconnectRetries = ReconnectRetries
                };

                // Create session
                lbLog.Items.Add($"Connecting as {UserName}@{VPNName} on {Host}...");
                session = context.CreateSession(sessionProps, null, null);
                ReturnCode returnCode = session.Connect();
                isCotext = returnCode == ReturnCode.SOLCLIENT_OK;
                isSession = true;
                lbLog.Items.Add($"Session successfully connected.");


                tbServer.Enabled = tbVPN.Enabled = tbName.Enabled = tbPassword.Enabled = false;
                btnConnect.Enabled = false;
                btnPub.Enabled = true;
            }
            catch (Exception ex)
            {
                lbLog.Items.Add(ex.Message);
            }
        }

        private void btnPub_Click(object sender, System.EventArgs e)
        {
            if (isSession)
            {
                PublishMessage(session, lbLog, tbSend);
            }
            else
            {
                //Console.WriteLine("Error connecting, return code: {0}", returnCode);
                lbLog.Items.Add($"Error connecting : {isSession}");
            }
        }

        

        private void PubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("종료 하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Dispose();
                ContextFactory.Instance.Cleanup();
                Application.ExitThread();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        
    }
}
