namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ReportCard
    {
        [Key]
        public Guid ReportId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(10)]
        public string? SchoolYear { get; set; }

        [Range(0, 10)]
        public float SemesterHK1Score { get; set; }

        [Range(0, 10)]
        public float SemesterHK2Score { get; set; }

        [Range(0, 10)]
        public float TotalScore { get; set; }

        public string? Performance { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }

}
