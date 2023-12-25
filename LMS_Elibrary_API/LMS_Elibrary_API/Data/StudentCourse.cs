using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS___Elibrary.Data
{

    [Table("StudentCourse")]
    public class StudentCourse
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string ClassId { get; set; }
        [Required]
        public string StudentId { get; set; }

        public virtual Classes Class { get; set; }
        public virtual User Student { get; set; }


    }
}
