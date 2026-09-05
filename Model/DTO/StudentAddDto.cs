namespace StudentApi.DTO
{
    public class StudentAddDto
    {
        public string StudentNumber { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string Birthplace { get; set; } = string.Empty;
    }
}
