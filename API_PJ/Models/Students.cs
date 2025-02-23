namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;

    public class Student
    {
        [Key]
        [Column("student_Id")]
        public Guid StudentId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("fullname")]
        public string? Fullname { get; set; }

        [Required]
        [Column("birth")]
        public DateTime Birth { get; set; }

        [Column("phone")]
        public int? Phone { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [Column("class_Id")]
        public Guid ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class? Class { get; set; }
    }

}
