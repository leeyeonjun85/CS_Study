using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace DX1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly ILogger _logger;

        ILoggerFactory loggerFactory;

private readonly IBusinessLayer _business;
        public Form1(ILogger<Form1> logger, ILoggerFactory loggerFactory)
        {
            loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                    .AddEventLog();
            });

            _logger = loggerFactory.CreateLogger<Form1>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);

                _logger.LogInformation("테스트로그 information.");
                _logger.LogCritical("테스트로그 critical information.");
                _logger.LogDebug("테스트로그 debug information.");
                _logger.LogError("테스트로그 error information.");
                _logger.LogTrace("테스트로그 trace");
                _logger.LogWarning("테스트로그 warning.");

                // Perform Business Logic here   

                MessageBox.Show("Hello .NET Core 3.0 . This is First Forms app in .NET Core");

                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Ended", DateTime.UtcNow);

            }
            catch (Exception ex)
            {
                //Log technical exception   
                _logger.LogError(ex.Message);
                //Return exception repsponse here  
                throw;

            }

        }

        //public Form1()
        //{
        //    InitializeComponent();
        //}


    }
}
