using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyManagementSystem.Common.Models;

namespace PropertyManagementSystem.Data
{
    public class PropertyManagementSystemContext : DbContext
    {
        public PropertyManagementSystemContext (DbContextOptions<PropertyManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<PropertyManagementSystem.Common.Models.Student> Student { get; set; }

        public DbSet<PropertyManagementSystem.Common.Models.Property> Property { get; set; }

        public DbSet<PropertyManagementSystem.Common.Models.Lease> Lease { get; set; }
    }
}
