namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SCHEDULES")]
    public class Schedule
    {
        [Key]
        [Column("schedule_id")] // Đổi thành chữ thường để đồng bộ với PostgreSQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ScheduleId { get; set; } = Guid.NewGuid();

        [Column("room")]
        [MaxLength(50)] // Giới hạn độ dài tối đa 50 ký tự
        public string? Room { get; set; }

        [Required]
        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Column("end_time")]
        public DateTime EndTime { get; set; }

        [Column("detail")]
        [StringLength(500)] // Giới hạn mô tả tối đa 500 ký tự
        public string? Detail { get; set; }

        [Required]
        [Column("class_id")]
        public Guid ClassId { get; set; }

        [Required]
        [Column("subject_id")]
        public Guid SubjectId { get; set; }

        [Required]
        [Column("teacher_id")]
        public Guid TeacherId { get; set; }

        
    }
}
