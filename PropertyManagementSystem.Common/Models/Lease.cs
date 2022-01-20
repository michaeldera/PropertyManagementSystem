namespace PropertyManagementSystem.Common.Models
{
    public class Lease
    {
        public int Id { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int Deposit { get; set; }
        public int PropertyId { get; set; }
        public int RentAmount { get; set; }
        public virtual Property Property { get; set; }
        public int StudentId { get; set; }
        public virtual StudentLessee Student { get; set; }

    }
}
