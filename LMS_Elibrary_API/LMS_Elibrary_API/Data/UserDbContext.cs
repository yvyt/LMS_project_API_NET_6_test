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
            modelBuilder.Entity<Topic>()
            .HasOne(t => t.Classes)
            .WithMany(tp => tp.Topics)
            .HasForeignKey(t => t.ClassId);
            modelBuilder.Entity<Lesson>()
            .HasOne(l => l.Topic)
            .WithMany(ls => ls.Lessons)
            .HasForeignKey(l => l.TopicId);
            modelBuilder.Entity<Classes>()
                .HasOne(te => te.TeacherUser)
                .WithMany(us => us.Classes)
                .HasForeignKey(t => t.Teacher);
            modelBuilder.Entity<Classes>()
               .HasOne(te => te.Course)
               .WithMany(us => us.Classes)
               .HasForeignKey(t => t.CourseId);
            modelBuilder.Entity<StudentCourse>()
            .HasOne(sc => sc.Student)
            .WithMany(u => u.StudentCourses)
            .HasForeignKey(sc => sc.StudentId);


            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Class)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.ClassId);

            modelBuilder.Entity<PrivateFile>()
                .HasOne(t => t.FileType)
                .WithMany(t => t.PrivateFiles)
                .HasForeignKey(k => k.TypeId);
            modelBuilder.Entity<PrivateFile>()
                .HasOne(u => u.Owner)
                .WithMany(us => us.PrivateFiles)
                .HasForeignKey(k => k.UserId);
            modelBuilder.Entity<Resource>()
                .HasOne(c => c.Course)
                .WithMany(r => r.Resources)
                .HasForeignKey(r => r.CourseId);
            modelBuilder.Entity<Resource>()
                .HasOne(c => c.Type)
                .WithMany(r => r.Resources)
                .HasForeignKey(r => r.TypeId);
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.Resources)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Type)
                .WithMany(e => e.Exams)
                .HasForeignKey(e => e.TypeId);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Course)
                .WithMany(e=>e.Exams)
                .HasForeignKey(e => e.CourseId);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Owner)
                .WithMany(e => e.Exams)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<ExamStudent>()
                .HasOne(e => e.Exams)
                .WithMany(e => e.ExamStudents)
                .HasForeignKey(e => e.ExamId);
            modelBuilder.Entity<ExamStudent>()
                .HasOne(e => e.Students)
                .WithMany(e => e.ExamStudents)
                .HasForeignKey(e => e.StudentId);
        }
    }
}
