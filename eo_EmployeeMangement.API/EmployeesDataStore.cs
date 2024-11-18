using eo_EmployeeMangement.API.Models;

namespace eo_EmployeeMangement.API
{
    public class EmployeesDataStore
    {
        // Create a list of Employee objects.
        public List<EmployeeDTO> Employees { get; set; }

        // Returns just an instance of this Employees object collection.
        public static EmployeesDataStore Current { get; } = new EmployeesDataStore();

        // Constructor to build base dummy data.
        public EmployeesDataStore()
        {
            Employees = new List<EmployeeDTO>()
            {
                new EmployeeDTO()
                {
                    Id = 1,
                    Name = "John Doe",
                    Position = "Programmer Analyst",
                    StartDate = DateOnly.Parse("10/20/2001")
                },
                new EmployeeDTO()
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Position = "Programmer Analyst II",
                    StartDate = DateOnly.Parse("03/10/2001")
                },
                new EmployeeDTO()
                {
                    Id = 3,
                    Name = "Jim Dane",
                    Position = "Senior Programmer",
                    StartDate = DateOnly.Parse("05/23/1997")
                }
            };
        }
    }
}
