using PropertyManagementSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem.Common.Models
{
    public class Room : ILeaseable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Number { get; set; }
    }
}
