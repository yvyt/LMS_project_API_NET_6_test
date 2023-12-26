using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Elibrary_API.Data
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string QuestionId { get; set; }

        [StringLength(500)]
        [Required]
        public string Content { get; set; }

        [Required]

        public bool IsCorrect { get; set; } = false;

        // Navigation property
        public virtual Question Question { get; set; }
    }

}