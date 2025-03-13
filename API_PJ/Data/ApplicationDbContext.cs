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
            modelBuilder.Entity<Schedule>().ToTable("SCHEDULES");
            modelBuilder.Entity<Student>().ToTable("STUDENTS");
            modelBuilder.Entity<Subject>().ToTable("SUBJECTS");
            modelBuilder.Entity<Teacher>().ToTable("TEACHERS");

            // Khóa ngoại giữa Student và Class (không sử dụng navigation property)
            modelBuilder.Entity<Student>()
                .HasOne<Class>()   // Chỉ định kiểu Class mà không dùng navigation property
                .WithMany()        // Không có navigation property ngược lại
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Cascade);


            // Khóa ngoại giữa Teacher và Subject
            modelBuilder.Entity<Teacher>()
                .HasOne<Subject>()
                .WithMany()
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình khóa ngoại giữa Class và Teacher mà không sử dụng navigation property ngược lại:
            modelBuilder.Entity<Class>()
                .HasOne<Teacher>()   // Không chỉ định navigation property
                .WithMany()          // Không có navigation property ngược lại
                .HasForeignKey(c => c.MainTeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Schedule và Class
            modelBuilder.Entity<Schedule>()
                .HasOne<Class>()      // Không sử dụng navigation property
                .WithMany()           // Không có navigation property ngược lại
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Schedule và Subject
            modelBuilder.Entity<Schedule>()
                .HasOne<Subject>()    // Không sử dụng navigation property
                .WithMany()           // Không có navigation property ngược lại
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Khóa ngoại giữa Schedule và Teacher
            modelBuilder.Entity<Schedule>()
                .HasOne<Teacher>()    // Không sử dụng navigation property
                .WithMany()           // Không có navigation property ngược lại
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Grade>()
            .HasKey(g => g.GradeId);




            // Khóa ngoại giữa Notification và Event
            modelBuilder.Entity<Notification>()
                .HasOne<Event>()
                .WithMany()
                .HasForeignKey(n => n.EventId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
