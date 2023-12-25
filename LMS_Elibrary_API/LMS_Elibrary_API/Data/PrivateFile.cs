using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS___Elibrary.Data;

namespace LMS_Elibrary_API.Data
{
    [Table("Private_File")]
    public class PrivateFile
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Column("name")]
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string TypeId { get; set; }

        [Column("type")]
        public string UserId { get; set; }

        [Column("size")]
        public int Size { get; set; }

        [Column("link")]
        [StringLength(255)]
        [Required]
        public string Link { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        // Navigation property
        public virtual FileType FileType { get; set; }
        public virtual User Owner { get; set; }
    }
}
