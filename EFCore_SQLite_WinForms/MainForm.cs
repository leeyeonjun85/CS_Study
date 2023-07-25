using EFCore_SQLite_WinForms.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_SQLite_WinForms
{
    public partial class MainForm : Form
    {
        string _connectionString = "Data Source=SchoolStudent.db";
        ModelContext context;

        public MainForm()
        {
            InitializeComponent();
            context = new ModelContext();

            Load += MainForm_Load!;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            context.Database.EnsureCreated();
            context.students.Load();
            dataGridView1.DataSource = context.students.Local.ToBindingList();
        }
    }
}