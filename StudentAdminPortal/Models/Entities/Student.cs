using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentAdminPortal.Models.Entities
{
    public class Student
    {
        [Key]
        [JsonPropertyName("id")] 
        public Guid Id { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Fees { get; set; }
    }
}