using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS___Elibrary.Data;

namespace LMS_Elibrary_API.Data
{
    [Table("Resource")]
    public class Resource
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string TypeId { get; set; }


        [Required]
        public string CourseId { get; set; }

        [Required]
        public DateTime ApprovalAt { get; set; }

        [Required]
        public bool Status { get; set; } = false;

        [StringLength(255)]
        [Required]
        public string Link { get; set; }

        [Required]
        public string UserId { get; set; }

        [Column(TypeName = "timestamp")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        // Navigation property
        public virtual FileType Type { get; set; }
        public virtual Course Course { get; set; }
        public virtual User Owner { get; set; }
    }
}
