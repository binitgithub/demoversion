using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoversion.DTOs
{
    public class PayrollDTO
    {
    public int PayrollId { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public DateTime PayDate { get; set; }
    public decimal GrossSalary { get; set; }
    public decimal TaxDeductions { get; set; }
    public decimal NetSalary { get; set; }
    }
}