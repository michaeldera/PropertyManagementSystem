namespace PropertyManagementSystem.Common.Interfaces
{
    public interface ILessee
    {
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int NationalId { get; set; }
    }
}
