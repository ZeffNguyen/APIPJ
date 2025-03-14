namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Class
    {
        [Key]
        [Column("class_id")] // Đổi thành chữ thường để đồng bộ với PostgreSQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ClassId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("class_name")]
        public string ClassName { get; set; } // Bỏ ? vì class phải có tên

        [Range(1, int.MaxValue)]
        [Column("max_student")]
        public int MaxStudent { get; set; }

        [Column("detail")]
        public string? Detail { get; set; }

        [Column("main_teacher_id")] // Đổi về chữ thường để nhất quán
        public Guid? MainTeacherId { get; set; } // Cho phép null nếu chưa có giáo viên chủ nhiệm
    }
}
