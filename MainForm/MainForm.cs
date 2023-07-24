using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        private readonly IProductService _context;
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;


        public MainForm(IProductService context)
        {
            _context = context;
            InitializeComponent();
        }

        //public MainForm(IDbContextFactory<ApplicationDbContext> contextFactory)
        //{
        //    _contextFactory = contextFactory;
        //    InitializeComponent();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load products and display them in the UI (GridView, ListBox, etc.)
            var products = _context.GetAllProducts();
            dataGridView1.DataSource = products;
            // Populate your UI elements with the product data
        }
    }

    

    public interface IProductService
    {
        List<Product> GetAllProducts();

        void Open(); void Close();
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
        public void Close()
        {
            Console.WriteLine("데이타베이스에 연결이 닫혔습니다.");
        }

        public void Open()
        {
            Console.WriteLine("데이타베이스에 연결이 열렸습니다");
        }
    }
}