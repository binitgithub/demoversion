using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoversion.Models
{
    public class Department
    {
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public ICollection<Employee> Employees { get; set; }
    }
}