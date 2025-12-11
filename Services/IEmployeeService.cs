using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Task<Employee> GetByIdAsync(int id);
    }
}
