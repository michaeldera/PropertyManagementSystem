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

        public DbSet<StudentLessee> Student { get; set; }

        public DbSet<Property> Property { get; set; }

        public DbSet<Lease> Lease { get; set; }

        public DbSet<Transaction> Transaction { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<NonStudentLessee> NonStudentLessee { get; set; }

        public DbSet<PropertyType> PropertyType { get; set; }
    }
}
