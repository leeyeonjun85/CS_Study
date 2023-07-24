using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFCore_SQLite_WinForms
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string? Name { get; set; }

        public virtual List<Product> Products { get; } = new();
    }
}
