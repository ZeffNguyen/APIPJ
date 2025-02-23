namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Admin
    {
        [Key]
        [Column("id")] // Map với tên trong DB
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("NAME")] // Map với tên trong DB
        public string? Name { get; set; }

        [Required]
        [Column("PASS")] // Map với tên trong DB
        public string? Password { get; set; }

        [Column("checkuser")] // Map với tên trong DB
        public bool CheckUser { get; set; }
    }

}
