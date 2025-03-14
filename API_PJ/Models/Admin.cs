namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Admin
    {
        [Key]
        [Column("admin_id")] // Map với tên trong DB
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AdminId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("name")] // Đổi về chữ thường để tránh lỗi PostgreSQL
        public string Name { get; set; }

        [Required]
        [Column("pass")] // Đổi về chữ thường để tránh lỗi PostgreSQL
        public string Password { get; set; }

        [Column("checkuser")] // Không cần đổi
        public bool CheckUser { get; set; }
    }
}
