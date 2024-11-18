using Microsoft.AspNetCore.Mvc;

namespace eo_EmployeeMangement.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetEmployees()
        {
            // Returns dummy data from the Employees Current instance.
            return new JsonResult(
                EmployeesDataStore.Current.Employees
                );
        }

        [HttpGet("{id}")]
        public JsonResult GetEmployee(int id)
        {
            return new JsonResult(
                EmployeesDataStore.Current.Employees.FirstOrDefault(e => e.Id == id));
        }
    }
}
