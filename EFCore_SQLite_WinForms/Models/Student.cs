using System.ComponentModel.DataAnnotations;

namespace EFCore_SQLite_WinForms.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        public string? name { get; set; }

        public int schoolId { get; set; }
        public virtual School? school { get; set; }
    }
}
