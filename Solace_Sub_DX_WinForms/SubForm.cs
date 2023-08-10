using SolaceSystems.Solclient.Messaging;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Solace_Sub_DX_WinForms
{
    public partial class SubForm : DevExpress.XtraEditors.XtraForm
    {
        const int ReconnectRetries = 3;

        private IContext context;
        private ISession session = null;
        private readonly EventWaitHandle WaitEventWaitHandle = new AutoResetEvent(false);

        public bool isCotext { get; set; } = false;
        public bool isSession { get; set; } = false;
        string Host { get; set; }
        string VPNName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        public SubForm()
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
            btnSubStart.Enabled = btnSubStop.Enabled = false;
        }

        private void HandleMessage(object source, MessageEventArgs args)
        {
            //Console.WriteLine("Received published message.");
            lbLog.Items.Add($"Received published message.");
            // Received a message
            using (IMessage message = args.Message)
            {
                // Expecting the message content as a binary attachment
                //Console.WriteLine("Message content: {0}", Encoding.ASCII.GetString(message.BinaryAttachment));
                lbLog.Items.Add($"Message content: {Encoding.ASCII.GetString(message.BinaryAttachment)}");
                // finish the program
                WaitEventWaitHandle.Set();
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
                session = context.CreateSession(sessionProps, HandleMessage, null);
                ReturnCode returnCode = session.Connect();
                isCotext = returnCode == ReturnCode.SOLCLIENT_OK;
                isSession = true;
                lbLog.Items.Add($"Session successfully connected.");


                tbServer.Enabled = tbVPN.Enabled = tbName.Enabled = tbPassword.Enabled = false;
                btnConnect.Enabled = false;
                btnSubStart.Enabled = true;
            }
            catch (Exception ex)
            {
                lbLog.Items.Add(ex.Message);
            }
        }

        private void btnSubStart_Click(object sender, EventArgs e)
        {
            if (isCotext)
            {
                btnSubStart.Enabled = false;
                btnSubStop.Enabled = true;

                // This is the topic on Solace messaging router where a message is published
                // Must subscribe to it to receive messages
                session.Subscribe(ContextFactory.Instance.CreateTopic("tutorial/topic"), true);

                //Console.WriteLine("Waiting for a message to be published...");
                lbLog.Items.Add($"Waiting for a message to be published...");
                //WaitEventWaitHandle.WaitOne(timeout:TimeSpan.FromMilliseconds(5000), exitContext:true);
                WaitEventWaitHandle.WaitOne();
            }
            else
            {
                //Console.WriteLine("Error connecting, return code: {0}", returnCode);
                lbLog.Items.Add($"Error connecting : {isCotext}");
            }
        }

        private void btnSubStop_Click(object sender, EventArgs e)
        {
            try
            {
                session.Dispose();
                tbServer.Enabled = tbVPN.Enabled = tbName.Enabled = tbPassword.Enabled = btnConnect.Enabled = true;
                btnSubStop.Enabled = isSession = false;

                lbLog.Items.Add($"Session Disconnect!");
            }
            catch (Exception ex)
            {
                lbLog.Items.Add($"{ex.Message}");
            }

        }

        private void SubForm_FormClosing(object sender, FormClosingEventArgs e)
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
