using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoversion.Models
{
    public class Payroll
    {
    public int PayrollId { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public DateTime PayDate { get; set; }
    public decimal GrossSalary { get; set; }
    public decimal TaxDeductions { get; set; }
    public decimal NetSalary { get; set; }
    }
}