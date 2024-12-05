using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoversion.Models;

namespace demoversion.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<Employee> GetEmpByIdAsync(int id);
    }
}