namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Grade
    {
        [Key]
        [Column("grade_Id")]
        public Guid GradeId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(10)]
        [Column("school_year")]
        public string? SchoolYear { get; set; }

        [Required]
        [Column("semester")]
        public string? Semester { get; set; }

        [Required]
        [Column("test_type")]
        public string? TestType { get; set; }


        [Range(0, 10)]
        [Column("score")]
        public double Score { get; set; }

        [Required]
        [Column("student_Id")]
        public Guid StudentId { get; set; }

        [Required]
        [Column("subject_Id")]
        public Guid? SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }

    public enum SemesterEnum
    {
        HK1,
        HK2
    }

    public enum TestTypeEnum
    {
        M,
        _15p,
        _60p,
        _90p,
        HK
    }

}
