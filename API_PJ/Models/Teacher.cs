namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher
    {
        [Key]
        public Guid TeacherId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string? FullName { get; set; }

        public int? Phone { get; set; }

        public string? Email { get; set; }

        public string? Degree { get; set; }

        public string? Detail { get; set; }

        [Required]
        public Guid SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }

}
