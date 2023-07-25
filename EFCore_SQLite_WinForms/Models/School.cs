using System.ComponentModel.DataAnnotations;

namespace EFCore_SQLite_WinForms.Models
{
    public class School
    {
        [Key]
        public int schoolId { get; set; }

        public string? name { get; set; }

        public virtual List<Student> students { get; } = new();
    }
}
