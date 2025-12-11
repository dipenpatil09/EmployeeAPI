using EmployeeAPI.Data;
using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MyDBContext myDBContext;
        public EmployeeRepository(MyDBContext dbContext)
        {
            myDBContext = dbContext;
        }

       
        public async Task<Employee> GetByIdAsync(int id)
        {
            return await myDBContext.Employees.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
