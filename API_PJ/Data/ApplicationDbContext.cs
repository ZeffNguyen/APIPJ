using API_PJ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL; // Thêm dòng này


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
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Đổi tên bảng về chữ thường (PostgreSQL phân biệt hoa thường)
            modelBuilder.Entity<Admin>().ToTable("admins");
            modelBuilder.Entity<Class>().ToTable("classes");
            modelBuilder.Entity<Event>().ToTable("events");
            modelBuilder.Entity<Grade>().ToTable("grades");
            modelBuilder.Entity<Notification>().ToTable("notifications");
            modelBuilder.Entity<Schedule>().ToTable("schedules");
            modelBuilder.Entity<Student>().ToTable("students");
            modelBuilder.Entity<Subject>().ToTable("subjects");
            modelBuilder.Entity<Teacher>().ToTable("teachers");

            // Cấu hình khóa chính là GUID
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Teacher>()
                .Property(t => t.TeacherId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Subject>()
                .Property(s => s.SubjectId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Class>()
                .Property(c => c.ClassId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Schedule>()
                .Property(s => s.ScheduleId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Grade>()
                .Property(g => g.GradeId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Notification>()
                .Property(n => n.NotificationId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Event>()
                .Property(e => e.EventId)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Admin>()
                .Property(a => a.AdminId)
                .HasDefaultValueSql("gen_random_uuid()");

            // Ràng buộc khóa ngoại
            modelBuilder.Entity<Student>()
                .HasOne<Class>()
                .WithMany()
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict); // Tránh lỗi xóa

            modelBuilder.Entity<Teacher>()
                .HasOne<Subject>()
                .WithMany()
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Class>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(c => c.MainTeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne<Class>()
                .WithMany()
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne<Subject>()
                .WithMany()
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grade>()
                .HasKey(g => g.GradeId);

            modelBuilder.Entity<Notification>()
                .HasOne<Event>()
                .WithMany()
                .HasForeignKey(n => n.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydata;Username=postgres;Password=binh123;");
            }
        }
    }
}
