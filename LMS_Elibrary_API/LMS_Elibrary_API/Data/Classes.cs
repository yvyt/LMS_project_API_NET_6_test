using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS___Elibrary.Data
{

    [Table("Classes")]
    public class Classes
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Teacher { get; set; }

        [Required]
        public string CourseId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual Course Course { get; set; }


        public virtual User TeacherUser { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
