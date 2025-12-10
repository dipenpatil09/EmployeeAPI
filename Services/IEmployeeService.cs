using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Employee GetById(int id);
    }
}
