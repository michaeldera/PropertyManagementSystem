using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementSystem.Common.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public Address Address { get; set; }
        public PropertyType Type { get; set; }
    }
}
