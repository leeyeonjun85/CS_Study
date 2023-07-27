﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oracle_EFCore.Models
{
    [Table("school")]
    public class School
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name", TypeName = "VARCHAR")]
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
    }
}
