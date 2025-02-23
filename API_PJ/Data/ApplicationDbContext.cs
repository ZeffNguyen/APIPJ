using API_PJ.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PJ.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Khai báo DbSet cho từng bảng
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<ReportCard> ReportCards { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ánh xạ tên bảng chính xác
            modelBuilder.Entity<Admin>().ToTable("ADMIN");
            modelBuilder.Entity<Class>().ToTable("CLASSES");
            modelBuilder.Entity<Event>().ToTable("EVENTS");
            modelBuilder.Entity<Grade>().ToTable("GRADES");
            modelBuilder.Entity<Notification>().ToTable("NOTIFICATIONS");
            modelBuilder.Entity<ReportCard>().ToTable("REPORT_CARDS");
            modelBuilder.Entity<Schedule>().ToTable("SCHEDULES");
            modelBuilder.Entity<Student>().ToTable("STUDENTS");
            modelBuilder.Entity<Subject>().ToTable("SUBJECTS");
            modelBuilder.Entity<Teacher>().ToTable("TEACHERS");

            // Khóa ngoại giữa Student và Class
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany()
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Teacher và Subject
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Subject)
                .WithMany()
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Class và Teacher (Giáo viên chủ nhiệm)
            modelBuilder.Entity<Class>()
                .HasOne(c => c.MainTeacher)
                .WithMany()
                .HasForeignKey(c => c.MainTeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Schedule và các bảng khác
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Class)
                .WithMany()
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Subject)
                .WithMany()
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Teacher)
                .WithMany()
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Grade và các bảng khác
            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany()
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Subject)
                .WithMany()
                .HasForeignKey(g => g.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa ReportCard và các bảng khác
            modelBuilder.Entity<ReportCard>()
                .HasOne(r => r.Student)
                .WithMany()
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReportCard>()
                .HasOne(r => r.Subject)
                .WithMany()
                .HasForeignKey(r => r.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Notification và Event
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Event)
                .WithMany()
                .HasForeignKey(n => n.EventId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
