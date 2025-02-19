namespace API_PJ.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Admin
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Required]
        public string? Password { get; set; }

        public bool CheckUser { get; set; }
    }

}
