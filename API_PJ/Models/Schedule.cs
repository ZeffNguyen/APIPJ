namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SCHEDULES")]
    public class Schedule
    {
        [Key]
        [Column("schedule_Id")]
        public Guid ScheduleId { get; set; } = Guid.NewGuid();

        [Column("room")]
        public string? Room { get; set; }

        [Required]
        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Column("end_time")]
        public DateTime EndTime { get; set; }

        [Column("detail")]
        public string? Detail { get; set; }

        [Required]
        [Column("class_Id")]
        public Guid ClassId { get; set; }

        [Required]
        [Column("subject_Id")]
        public Guid SubjectId { get; set; }

        [Required]
        [Column("teacher_Id")]
        public Guid TeacherId { get; set; }

        [ForeignKey("ClassId")]
        public Class? Class { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
    }

}
