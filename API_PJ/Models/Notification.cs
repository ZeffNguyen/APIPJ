namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NOTIFICATIONS")]
    public class Notification
    {
        [Key]
        [Column("notification_id")] // Chuẩn hóa tên cột
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid NotificationId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(500)] // Giới hạn độ dài hợp lý
        [Column("message")]
        public string Message { get; set; } = string.Empty;

       

        [Required]
        [Column("event_id")]
        public Guid EventId { get; set; }
    }
}
