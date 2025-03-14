namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Subject
    {
        [Key]
        [Column("subject_id")] // Đổi thành chữ thường để đồng bộ với PostgreSQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SubjectId { get; set; }

        [Required]
        [Column("subject_name")] // Đổi về chữ thường để tránh lỗi PostgreSQL
        public string? SubjectName { get; set; }
    }
}
