using EmployeeAPI.Models;
using EmployeeAPI.Repositories;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository) 
        {
            _repository = repository;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            if (id < 0)
                return null;
            else
                return await _repository.GetByIdAsync(id);
        }
    }
}
