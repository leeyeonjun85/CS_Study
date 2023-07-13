using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_EFCore.Models
{
    [Table("room")]
    public class Room
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Column("school_id")]
        public int SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School? School { get; set; }

        public ICollection<Student>? Students { get; set; }

    }
}
