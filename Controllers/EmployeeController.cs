using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoversion.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace demoversion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
            
        }

        //All Emplyee Data
        [HttpGet]
        public async Task<IActionResult> GetEmpAll(){
            var EmpDomain = await employeeRepository.GetAllEmployeeAsync();
            return Ok(EmpDomain);
        }

        //All Employee Get By Id
        [HttpGet("{id:in}")]
        public async Task<IActionResult> GetEmplById([FromRoute] int id){
            
        }
        
    }
}