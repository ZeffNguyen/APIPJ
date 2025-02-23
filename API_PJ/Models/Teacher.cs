namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher
    {
        [Key]
        [Column("teacher_Id")]
        public Guid TeacherId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("full_name")]
        public string? FullName { get; set; }

        [Column("phone")]
        public int? Phone { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("degree")]
        public string? Degree { get; set; }

        [Column("detail")]
        public string? Detail { get; set; }

        [Required]
        [Column("subject_Id")]
        public Guid SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }

}
