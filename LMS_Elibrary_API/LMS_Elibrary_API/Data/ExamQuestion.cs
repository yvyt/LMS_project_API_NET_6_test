using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Elibrary_API.Data
{
    [Table("ExamQuestion")]
    public class ExamQuestion
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string QuestionId { get; set; }

        [Required]
        public string ExamId { get; set; }

        // Navigation properties
        public virtual Question Question { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
