namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GRADES")]
    public class Grade
    {
        [Key]
        [Column("grade_id")] // Chuẩn hóa tên cột
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GradeId { get; set; } = Guid.NewGuid();

        [Required]
        [Column("school_year")]
        [MaxLength(9)] // VD: "2024-2025"
        public string SchoolYear { get; set; } = string.Empty;

        [Column("semester_hk1_score")]
        [Range(0, 10, ErrorMessage = "Điểm HK1 phải từ 0 đến 10")]
        public double? SemesterHK1Score { get; set; }

        [Column("semester_hk2_score")]
        [Range(0, 10, ErrorMessage = "Điểm HK2 phải từ 0 đến 10")]
        public double? SemesterHK2Score { get; set; }

        [Required]
        [Column("student_id")]
        [ForeignKey("Student")] // Liên kết với bảng STUDENTS
        public Guid StudentId { get; set; }

        [Required]
        [Column("subject_id")]
        [ForeignKey("Subject")] // Liên kết với bảng SUBJECTS
        public Guid SubjectId { get; set; }
    }
}
