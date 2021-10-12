using EmployeeFace.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeFace.DataAccess.Repository
{
    public class EmployeeDAO : IEmployeeDAO
    {

        private readonly EmployeeDBContext dbContext;

        public EmployeeDAO(EmployeeDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            await dbContext.Employee.AddAsync(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public List<Employee> GetAll()
        {
            return dbContext.Employee.ToList();
        }

        public async Task<Employee> GetEmployeeById(int? id)
        {
            Employee employee = await dbContext.Employee.FindAsync(id);

            if (employee == null)
            {
                return null;
            }

            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var checkEmployee = await GetEmployeeById(employee.Id);
            if (checkEmployee == null)
                return null;

            var local = dbContext.Set<Employee>()
                .Local
                .FirstOrDefault(entry => entry.Id.Equals(employee.Id));

            if (local != null)
            {
                // detach
                dbContext.Entry(local).State = EntityState.Detached;
            }

            dbContext.Entry(employee).State = EntityState.Modified;

            dbContext.Employee.Update(employee);
            await dbContext.SaveChangesAsync();

            return employee;
        }
    }
}
