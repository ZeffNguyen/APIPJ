namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        [Key]
        public Guid EventId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
    }

}
