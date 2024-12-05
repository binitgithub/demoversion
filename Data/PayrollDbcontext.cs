using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoversion.Models;
using Microsoft.EntityFrameworkCore;

namespace demoversion.Data
{
    public class PayrollDbcontext : DbContext
    {
        public PayrollDbcontext(DbContextOptions<PayrollDbcontext> options) : base (options)
        {
            
        }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<Leave> Leaves { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure model relationships and properties here
        
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId);

        modelBuilder.Entity<Payroll>()
            .HasOne(p => p.Employee)
            .WithMany()
            .HasForeignKey(p => p.EmployeeId);

        modelBuilder.Entity<Leave>()
            .HasOne(l => l.Employee)
            .WithMany()
            .HasForeignKey(l => l.EmployeeId);

        base.OnModelCreating(modelBuilder);
    }
    }
}