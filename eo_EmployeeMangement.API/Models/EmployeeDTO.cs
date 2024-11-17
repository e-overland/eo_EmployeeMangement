namespace eo_EmployeeMangement.API.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; }
        public DateOnly StartDate { get; set; }

    }
}
