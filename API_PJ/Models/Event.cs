namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EVENTS")]
    public class Event
    {
        [Key]
        [Column("event_id")] // Chuẩn hóa tên cột
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EventId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("title")]
        public string Title { get; set; } = string.Empty; // Không cho phép NULL

        [Required] // Bắt buộc nhập mô tả
        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Column("end_time")]
        public DateTime EndTime { get; set; }
    }
}
