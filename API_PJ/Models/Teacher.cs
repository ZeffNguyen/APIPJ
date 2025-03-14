namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher
    {
        [Key]
        [Column("teacher_id")] // Đổi thành chữ thường để đồng bộ với PostgreSQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TeacherId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("full_name")]
        public string FullName { get; set; }

        [Column("phone")]
        public long? Phone { get; set; } // Dùng long để hỗ trợ số dài hơn

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Column("degree")]
        public string? Degree { get; set; }

        [Column("detail")]
        public string? Detail { get; set; }

        [Required]
        [Column("subject_id")] // Đổi về chữ thường để nhất quán
        public Guid SubjectId { get; set; }
    }
}
