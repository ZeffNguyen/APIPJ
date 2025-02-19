namespace API_PJ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Class
    {
        [Key]
        public Guid ClassId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string? ClassName { get; set; }

        [Range(1, int.MaxValue)]
        public int MaxStudent { get; set; }

        public string? Detail { get; set; }

        [Required]
        public Guid MainTeacherId { get; set; }

        [ForeignKey("MainTeacherId")]
        public Teacher? MainTeacher { get; set; }
    }

}
