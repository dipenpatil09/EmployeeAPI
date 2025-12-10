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

        public Employee GetById(int id)
        {
            if (id < 0)
                return null;
            else
                return _repository.GetById(id);
        }
    }
}
