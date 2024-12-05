using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoversion.DTOs
{
    public class EmployeeDTO
    {
    public int EmployeeId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public decimal BaseSalary { get; set; }
    }
}