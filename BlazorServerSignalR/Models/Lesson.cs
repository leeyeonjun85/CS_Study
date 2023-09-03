using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlazorServerSignalR.Data;

namespace BlazorServerSignalR.Models
{
    [Table("LESSON")]
    public class Lesson
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }

        [Column("DATE_TIME_START")]
        public DateTime dateTimeStart { get; set; } = DateTime.Now;

        [Column("DATE_TIME_END")]
        public DateTime dateTimeEnd { get; set; } = DateTime.Now;

        [Column("LESSON_MEMO")]
        public string lessonMemo { get; set; }

        [Column("MEMBER_ID")]
        [Required]
        public int memberId { get; set; }

        [ForeignKey("memberId")]
        public virtual Members? member { get; set; }
    }
}
