using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oracle_OracleDependency.Models
{
    [Table("student")]
    public class Student
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Birthday { get; set; } = DateTime.UtcNow;

        [Column("room_id")]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room? Room { get; set; }
    }
}
