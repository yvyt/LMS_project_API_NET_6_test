using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS___Elibrary.Data;

namespace LMS_Elibrary_API.Data
{
    [Table("Question")]
    public class Question
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        [Required]
        public string ExamTypeId { get; set; }
        [Required]
        public int Level { get; set; }

        [Required]
        public bool IsMultiple { get; set; } = false;

        [StringLength(500)]
        [Required]
        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string ClassId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdateAt { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ExamType ExamType { get; set; }
        public virtual User Owner { get; set; }
        public virtual Classes Classes { get; set; }
        public virtual ICollection<Answer> Answers{ get;set;}
        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }

    }
}
