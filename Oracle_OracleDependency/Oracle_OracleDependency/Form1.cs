using Oracle.ManagedDataAccess.Client;
using Oracle_OracleDependency.Models;
using System.Data;

namespace Oracle_OracleDependency
{
    public partial class Form1 : Form
    {
        private OracleConnection connection;
        private OracleDataAdapter adapter;
        private DataTable dataTable;
        private OracleDependency dependency;
        string connectionString = $"User Id=testuser1;Password=0330;Data Source=localhost:1521/XEPDB1;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            // Create the connection
            connection = new OracleConnection(connectionString);

            // Create the adapter
            adapter = new OracleDataAdapter("SELECT * FROM \"school\"", connection);

            // Create the DataTable
            dataTable = new DataTable();
            //dataTable = new List<School>();
            //dataTable = new DataSet();

            // Fill the DataTable with initial data
            adapter.Fill(dataTable);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

            // Register the change notification
            RegisterChangeNotification();

            // Start the continuous update process
            StartContinuousUpdate();
        }

        private void RegisterChangeNotification()
        {
            // Set up the query to monitor changes
            string query = "SELECT * FROM \"school\"";
            OracleCommand command = new OracleCommand(query, connection);

            // Create the OracleDependency object
            dependency = new OracleDependency(command);

            // Set the notification callback
            dependency.OnChange += Dependency_OnChange;

            // Enable the database change notification
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Dependency_OnChange(object sender, OracleNotificationEventArgs args)
        {
            // Update the DataTable with changed data
            //dataTable.Invoke((MethodInvoker)(() =>
            //{
            //    adapter.Fill(dataTable);
            //}));
            if (args.Info.ToString() == "Insert")
            {
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.BeginInvoke(()=>
                    {
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Refresh();
                    }
                );
            }  
        }

        private void StartContinuousUpdate()
        {
            // Start a new thread to continuously update the DataTable in the background
            var updateThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    //adapter.Fill(dataTable);
                    System.Threading.Thread.Sleep(1000); // Delay between updates
                }
            });

            updateThread.IsBackground = true;
            updateThread.Start();
        }
    }
}
