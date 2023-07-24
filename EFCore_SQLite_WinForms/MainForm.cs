using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel;

namespace EFCore_SQLite_WinForms
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
            var databaseConnector = new DatabaseConnector(new SQLiteProvider());
            databaseConnector.Open();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this.dbContext
                        .Entry(category)
                        .Collection(e => e.Products)
                        .Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }

    public interface IDatabaseProvider
    {
        void Open(); void Close();
    }

    public class SQLiteProvider : IDatabaseProvider
    {
        public void Close()
        {
            Console.WriteLine("SQLite 데이타베이스에 연결이 닫혔습니다.");
        }

        public void Open()
        {
            var dddcontext = new ProductsContext();
            MessageBox.Show("SQLite 데이타베이스에 연결이 열렸습니다"+dddcontext.Database.GetConnectionString());
        }
    }

    public class DatabaseConnector
    {
        public IDatabaseProvider Connector { get; set; }

        public void Open()
        {
            Connector.Open();
        }

        public void Close()
        {
            Connector.Close();
        }

        public DatabaseConnector(IDatabaseProvider provider)
        {
            Connector = provider;
        }
    }
}