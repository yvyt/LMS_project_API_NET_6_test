﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS___Elibrary.Data
{
    [Table("Lesson")]

    public class Lesson
    {
       
            [Key]
            [StringLength(255)]
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public string Id { get; set; }
            [Required]
            public string TopicId { get; set; }
            [Required]
            [MaxLength(255)]
            public string Title { get; set; }
            [Required]
            public string Link { get; set; }
            [Required]
            public bool IsActive { get; set; } = true;
            [Required]
            public bool IsDeleted { get; set; } = false;

            public virtual Topic Topic { get; set; }
        }
    
}
