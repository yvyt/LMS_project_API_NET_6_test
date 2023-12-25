using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS___Elibrary.Data;

namespace LMS_Elibrary_API.Data
{
    [Table("ExamStudent")]
    public class ExamStudent
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        
        [Required]
        public string StudentId { get; set; }

        
        [Required]
        public string ExamId { get; set; }
        [Required]
        public DateTime EnrollAt { get; set; }

        // Navigation property
        public virtual Exam Exams { get; set; }
        public virtual User Students {  get; set; }
    }
}
