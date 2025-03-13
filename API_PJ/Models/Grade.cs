namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    
public class Grade
    {
        [Key]
        public Guid GradeId { get; set; } = Guid.NewGuid(); // Thêm khóa chính

        [Required]
        public string SchoolYear { get; set; } = string.Empty; // Khắc phục lỗi cảnh báo

        [Range(0, 10)]
        public float? SemesterHK1Score { get; set; }

        [Range(0, 10)]
        public float? SemesterHK2Score { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid SubjectId { get; set; }
    }


}
