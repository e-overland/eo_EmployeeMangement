namespace eo_EmployeeMangement.API.Models
{
    public class EmployeeDTO
    {
        // Id of Employee record.
        public int Id { get; set; }
        // Full name of the Employee.
        public string Name { get; set; } = string.Empty;
        // Name of the Employee's postition.
        public string Position { get; set; }
        // Start date of the employee with the company.
        public DateOnly StartDate { get; set; }

    }
}
