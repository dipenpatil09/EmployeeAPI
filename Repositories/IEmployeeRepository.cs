using EmployeeAPI.Models;

namespace EmployeeAPI.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
    }
}
