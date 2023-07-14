using EFCore_MySQL.Models;

namespace EFCore_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var context = new ModelsContext())
            {
                lblStatus.Text = context.Database.Exists().ToString();
            }
        }
    }
}