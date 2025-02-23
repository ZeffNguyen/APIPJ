namespace API_PJ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Class
    {
        [Key]
        [Column("class_Id")] // Map với tên trong DB
        public Guid ClassId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        [Column("class_name")] // Map với tên trong DB
        public string? ClassName { get; set; }

        [Range(1, int.MaxValue)]
        [Column("max_student")] // Map với tên trong DB
        public int MaxStudent { get; set; }

        [Column("detail")] // Map với tên trong DB
        public string? Detail { get; set; }

        [Required]
        [Column("main_teacher_Id")] // Map với tên trong DB
        public Guid MainTeacherId { get; set; }

        [ForeignKey("MainTeacherId")]
        public Teacher? MainTeacher { get; set; }
    }

}
