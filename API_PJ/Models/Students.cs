namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        [Key]
        [Column("student_id")] // Đổi thành chữ thường để đồng bộ với PostgreSQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("fullname")] // Đổi về full_name để nhất quán
        public string? FullName { get; set; }

        [Required]
        [Column("birth")]
        public DateTime Birth { get; set; }

        [Column("phone")]
        [MaxLength(15)] // Đảm bảo số điện thoại không quá dài
        public int? Phone { get; set; } // Đổi sang string để hỗ trợ số điện thoại quốc tế

        [Column("email")]
        [EmailAddress] // Kiểm tra định dạng email hợp lệ
        public string? Email { get; set; }

        [Required]
        [Column("class_id")] // Đổi về chữ thường để nhất quán
        public Guid ClassId { get; set; }
    }
}
