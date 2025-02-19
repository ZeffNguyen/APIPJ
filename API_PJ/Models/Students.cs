namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;

    public class Student
    {
        [Key]
        public Guid StudentId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string? Fullname { get; set; }

        [Required]
        public DateTime Birth { get; set; }

        public int? Phone { get; set; }

        public string? Email { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class? Class { get; set; }
    }

}
