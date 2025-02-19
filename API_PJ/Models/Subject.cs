namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Subject
    {
        [Key]
        [Column("subject_Id")] // Map với tên trong DB
        public Guid SubjectId { get; set; }

        [Column("subject_name")] // Map với tên trong DB
        public string? SubjectName { get; set; }
    }


}
