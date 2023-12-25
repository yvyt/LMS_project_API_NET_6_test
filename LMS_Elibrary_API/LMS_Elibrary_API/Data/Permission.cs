using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS___Elibrary.Data
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength(100)]
        [Required]
        public string PermissionName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<UserPermission> Permissions { get;}
    }
}
