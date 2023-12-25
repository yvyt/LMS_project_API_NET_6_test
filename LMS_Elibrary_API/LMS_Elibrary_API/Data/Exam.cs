using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS___Elibrary.Data;

namespace LMS_Elibrary_API.Data
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        
        [Required]
        public string TypeId { get; set; }

       
        [Required]
        public string CourseId { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]

        public bool Status { get; set; }

        [Required]

        public string Duration { get; set; }

      
        [Required]
        public string Link { get; set; }

        [Required]

        public DateTime CreatedAt { get; set; }

        [Required]

        public bool IsActive { get; set; } = true;

        [Required]

        public bool IsDeleted { get; set; } = false;

        [Required]
        public DateTime DateBegin { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ExamType Type { get; set; }
        public virtual Course Course { get; set; }
        public virtual User Owner {  get; set; }
        public virtual ICollection<ExamStudent> ExamStudents { get; set; }

    }
}
