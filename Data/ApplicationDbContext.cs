using EmployeeAdminPortal_CRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
