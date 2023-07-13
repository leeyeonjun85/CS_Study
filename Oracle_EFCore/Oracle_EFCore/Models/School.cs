using DevExpress.Xpo;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_EFCore.Models
{
    [Table("school")]
    public class School
    {
        [Column("id")]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Column("name", TypeName = "VARCHAR")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Room>? Rooms { get; set; }
    }
}
