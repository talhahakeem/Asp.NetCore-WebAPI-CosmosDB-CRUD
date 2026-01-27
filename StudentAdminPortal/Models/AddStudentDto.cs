namespace StudentAdminPortal.Models
{
    public class AddStudentDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Fees { get; set; }
    }
}