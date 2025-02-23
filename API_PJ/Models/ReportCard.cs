namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ReportCard
    {
        [Key]
        [Column("report_Id")]
        public Guid ReportId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(10)]
        [Column("school_year")]
        public string? SchoolYear { get; set; }

        [Range(0, 10)]
        [Column("semester_HK1_score")]
        public float SemesterHK1Score { get; set; }

        [Range(0, 10)]
        [Column("semester_HK2_score")]
        public float SemesterHK2Score { get; set; }

        [Range(0, 10)]
        [Column("total_score")]
        public float TotalScore { get; set; }

        [Column("performance")]
        public string? Performance { get; set; }

        [Required]
        [Column("student_Id")]
        public Guid StudentId { get; set; }

        [Required]
        [Column("subject_Id")]
        public Guid SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }

}
