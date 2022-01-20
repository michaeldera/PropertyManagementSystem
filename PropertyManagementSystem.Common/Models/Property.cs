using PropertyManagementSystem.Common.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementSystem.Common.Models
{
    public class Property : ILeaseable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public Address Address { get; set; }
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
