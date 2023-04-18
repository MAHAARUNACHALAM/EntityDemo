using EntityDemo.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
