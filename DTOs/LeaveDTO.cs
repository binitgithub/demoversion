using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoversion.DTOs
{
    public class LeaveDTO
    {
    public int LeaveId { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public bool IsApproved { get; set; }
    }
}