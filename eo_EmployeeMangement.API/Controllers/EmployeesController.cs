using Microsoft.AspNetCore.Mvc;

namespace eo_EmployeeMangement.API.Controllers
{
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public JsonResult GetEmployees()
        {
            return new JsonResult(
                new List<object> {
                    new { id = 1, Name = "John Doe"},
                    new { id = 2, Name = "Jane Doe"}
                });
        }
    }
}
