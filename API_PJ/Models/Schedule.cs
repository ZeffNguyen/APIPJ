namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Schedule
    {
        [Key]
        public Guid ScheduleId { get; set; } = Guid.NewGuid();

        public string? Room { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public string? Detail { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        [Required]
        public Guid SubjectId { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        [ForeignKey("ClassId")]
        public Class? Class { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
    }

}
