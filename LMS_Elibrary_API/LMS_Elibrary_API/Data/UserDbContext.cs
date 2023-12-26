using LMS_Elibrary_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace LMS___Elibrary.Data
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
            public DbSet<User> Users { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<Permission> Permissions { get; set; }
            public DbSet<UserRole> UserRoles {  get; set; }
            public DbSet<UserPermission> UserPermissions { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Topic> Topics { get; set; }
            public DbSet<Lesson> Lessons { get; set; }
            public DbSet<Classes> Classes { get; set; }
            public DbSet<StudentCourse> StudentCourses { get; set; }
            public DbSet<FileType> Types { get; set; }
            public DbSet<PrivateFile> PrivateFiles { get; set; }
            public DbSet<Resource> Resources { get; set; }
            public DbSet<ExamType> ExamTypes { get; set; }
            public DbSet<Exam> Exams { get; set; }

            public DbSet<ExamStudent> ExamStudents { get; set; }
            public DbSet<Question> Questions { get; set; }
            public DbSet<Answer> Answers { get; set; }
            public DbSet<ExamQuestion> ExamQuestions { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config relationship
            // user-role
            modelBuilder.Entity<UserRole>()
                 .HasOne(u => u.User)
                 .WithMany(us => us.Roles)
                 .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserRole>()
                .HasOne(r => r.Roles)
                .WithMany(u=>u.Roles)
                .HasForeignKey(r => r.RoleId);
            // user-permission
            modelBuilder.Entity<UserPermission>()
                .HasOne(u => u.User)
                .WithMany(u=>u.Permissions)
                .HasForeignKey(r => r.UserId);
            modelBuilder.Entity<UserPermission>()
                .HasOne(p=>p.Permission)
                .WithMany(u=>u.Permissions)
                .HasForeignKey(r => r.PermissionId);
            // class topic
            modelBuilder.Entity<Topic>()
            .HasOne(t => t.Classes)
            .WithMany(tp => tp.Topics)
            .HasForeignKey(t => t.ClassId);
            // lesson topic
            modelBuilder.Entity<Lesson>()
            .HasOne(l => l.Topic)
            .WithMany(ls => ls.Lessons)
            .HasForeignKey(l => l.TopicId);
            // class user
            modelBuilder.Entity<Classes>()
                .HasOne(te => te.TeacherUser)
                .WithMany(us => us.Classes)
                .HasForeignKey(t => t.Teacher);
            // class course
            modelBuilder.Entity<Classes>()
               .HasOne(te => te.Course)
               .WithMany(us => us.Classes)
               .HasForeignKey(t => t.CourseId);
            // course user
            modelBuilder.Entity<StudentCourse>()
            .HasOne(sc => sc.Student)
            .WithMany(u => u.StudentCourses)
            .HasForeignKey(sc => sc.StudentId);

            // student course class
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Class)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.ClassId);
            // private file - type
            modelBuilder.Entity<PrivateFile>()
                .HasOne(t => t.FileType)
                .WithMany(t => t.PrivateFiles)
                .HasForeignKey(k => k.TypeId);
            // PF - user
            modelBuilder.Entity<PrivateFile>()
                .HasOne(u => u.Owner)
                .WithMany(us => us.PrivateFiles)
                .HasForeignKey(k => k.UserId);
            // resource - class
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Classes)
                .WithMany(cl => cl.Resources)
                .HasForeignKey(r => r.ClassId);
            // resource - type
            modelBuilder.Entity<Resource>()
                .HasOne(c => c.Type)
                .WithMany(r => r.Resources)
                .HasForeignKey(r => r.TypeId);
            // resource - user
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.Resources)
                .HasForeignKey(r => r.UserId);
            // exam - type
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Type)
                .WithMany(e => e.Exams)
                .HasForeignKey(e => e.TypeId);
            // exam - class
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Classes)
                .WithMany(e=>e.Exams)
                .HasForeignKey(e => e.ClassId);
            // exam -user
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Owner)
                .WithMany(e => e.Exams)
                .HasForeignKey(e => e.UserId);
            // student exam - exam
            modelBuilder.Entity<ExamStudent>()
                .HasOne(e => e.Exams)
                .WithMany(e => e.ExamStudents)
                .HasForeignKey(e => e.ExamId);
            // student exam - user
            modelBuilder.Entity<ExamStudent>()
                .HasOne(e => e.Students)
                .WithMany(e => e.ExamStudents)
                .HasForeignKey(e => e.StudentId);
            // question - type
            modelBuilder.Entity<Question>()
                .HasOne(q => q.ExamType)
                .WithMany(q => q.Questions)
                .HasForeignKey(q => q.ExamTypeId);
            // question - user
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Owner)
                .WithMany(q => q.Questions)
                .HasForeignKey(q => q.UserId);
            // question - class
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Classes)
                .WithMany(q => q.Questions)
                .HasForeignKey(q => q.ClassId);
            // answer - question
            modelBuilder.Entity<Answer>()
                .HasOne(q => q.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(q => q.QuestionId);
            // ExamQuestion - Question
            modelBuilder.Entity<ExamQuestion>()
                .HasOne(ex => ex.Question)
                .WithMany(ex => ex.ExamQuestions)
                .HasForeignKey(ex => ex.QuestionId);
            // examquestion - exam
            modelBuilder.Entity<ExamQuestion>()
                .HasOne(ex => ex.Exam)
                .WithMany(ex => ex.ExamQuestions)
                .HasForeignKey(ex => ex.ExamId);



        }
    }
}
