using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoversion.Data;
using demoversion.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace demoversion.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PayrollDbcontext payrollContext;
        public EmployeeRepository(PayrollDbcontext payrollContext)
        {
            this.payrollContext = payrollContext;
            
        }
        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await payrollContext.Employees.ToListAsync();
            
        }

        public async Task<Employee> GetEmpByIdAsync(int id)
        {
           return await payrollContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }
    }
}