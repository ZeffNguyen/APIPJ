namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Event
    {
        [Key]
        [Column("event_Id")] // Map với tên trong DB
        public Guid EventId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("title")] // Map với tên trong DB
        public string? Title { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Column("end_time")]
        public DateTime EndTime { get; set; }
    }

}
