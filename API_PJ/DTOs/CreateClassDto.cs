namespace API_PJ.DTOs
{
    public class CreateClassDto
    {
        public string? ClassName { get; set; }
        public int MaxStudent { get; set; }
        public string? Detail { get; set; }
        public Guid MainTeacherId { get; set; }
    }
}
