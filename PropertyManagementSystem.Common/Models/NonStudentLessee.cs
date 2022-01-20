using PropertyManagementSystem.Common.Interfaces;

namespace PropertyManagementSystem.Common.Models
{
    public class NonStudentLessee : ILessee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int NationalId { get; set; }
        public string JobTitle { get; set; }
        public string Organisation { get; set; }
    }
}
