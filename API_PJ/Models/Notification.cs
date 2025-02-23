namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.Extensions.Logging;

    public class Notification
    {
        [Key]
        [Column("notification_Id")]
        public Guid NotificationId { get; set; } = Guid.NewGuid();

        [Required]
        [Column("message")]
        public string? Message { get; set; }

        [Required]
        [Column("create_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [Column("event_Id")]
        public Guid EventId { get; set; }

        [ForeignKey("EventId")]
        public Event? Event { get; set; }
    }

}
