using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem.Common.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int? StudentId { get; set; }
        public StudentLessee Student { get; set; }
    }
}
