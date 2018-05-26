using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ianmann.Hr.DataAccess.DataAccess.Employment
{
    public class EmploymentContext : DbContext
    {
        public EmploymentContext() : base("name=HrConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employment> Employments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employment>()
                        .HasRequired(e => e.Employee)
                        .WithOptional(e => e.Employment)
                        .Map(m => m.MapKey("EmployeeID"));
            modelBuilder.Entity<Employment>()
                        .HasRequired(e => e.Position)
                        .WithMany(e => e.Employments)
                        .Map(m => m.MapKey("PositionID"));
        }
    }
}
