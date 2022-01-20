using System.ComponentModel.DataAnnotations.Schema;
using PropertyManagementSystem.Common.Interfaces;

namespace PropertyManagementSystem.Common.Models
{
    public class StudentLessee : ILessee
    {
        public int Id { get; set; }
        public int NationalId { get; set; }
        public string StudentId { get; set; }
        public string Institution { get; set;}
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        [NotMapped]
        public Address HomeAddress { get; set; }
    }
}
