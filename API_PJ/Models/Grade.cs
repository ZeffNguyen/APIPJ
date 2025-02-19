namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Grade
    {
        [Key]
        public Guid GradeId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(10)]
        public string? SchoolYear { get; set; }

        [Required]
        [EnumDataType(typeof(SemesterEnum))]
        public SemesterEnum Semester { get; set; }

        [Required]
        [EnumDataType(typeof(TestTypeEnum))]
        public TestTypeEnum TestType { get; set; }

        [Range(0, 10)]
        public float Score { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [Required]
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
