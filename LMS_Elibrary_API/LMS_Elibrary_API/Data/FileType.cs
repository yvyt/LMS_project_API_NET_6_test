using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Elibrary_API.Data
{
    [Table("Type")]
    public class FileType
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
        public virtual ICollection<PrivateFile> PrivateFiles { get; set; }
    }
}
