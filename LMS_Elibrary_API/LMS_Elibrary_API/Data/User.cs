﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LMS_Elibrary_API.Data;

namespace LMS___Elibrary.Data
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(255)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Email { get; set; }

        [MaxLength(255)]
        [Required]
        public string Password { get; set; }

        [MaxLength(255)]
        [Required]

        public string FirstName { get; set; }

        [MaxLength(255)]
        [Required]

        public string LastName { get; set; }

        [MaxLength(10)]
        [Required]

        public string Gender { get; set; }

        [MaxLength(20)]
        [Required]
        public string Phone { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(255)]

        public string Avatar { get; set; }

        public bool IsFirstLogin { get; set; } = true;

        [MaxLength(255)]
        [Required]
        public string Address { get; set; }

        public bool IsActive { get; set; } = true;

        [Column(TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<UserRole> Roles { get; set; } = new HashSet<UserRole>();
        public virtual ICollection<UserPermission> Permissions { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<PrivateFile> PrivateFiles { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Exam> Exams {  get; set; }
        public virtual ICollection<ExamStudent> ExamStudents { get; set; }
        public virtual ICollection<Question> Questions { get; set; }


    }
}
