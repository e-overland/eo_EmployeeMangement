using eo_EmployeeMangement.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace eo_EmployeeMangement.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            // Returns dummy data from the Employees Current instance.
            return Ok(EmployeesDataStore.Current.Employees);
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeDTO> GetEmployee(int id)
        {
            EmployeeDTO employeeResult = EmployeesDataStore.Current.Employees
                .FirstOrDefault(e => e.Id == id);

            if (employeeResult == null)
            {
                return NotFound();
            }

            return Ok(employeeResult);
        }
    }
}
