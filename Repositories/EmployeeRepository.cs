using EmployeeAPI.Models;

namespace EmployeeAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "Sansa", Department = "IT", Salary = 80000 },
            new Employee { Id = 2, Name = "Arya", Department = "HR", Salary = 50000 }
        };

        public Employee GetById(int id)
        {
            return _employees.Where(x => x.Id == id)?.FirstOrDefault();
        }
    }
}
