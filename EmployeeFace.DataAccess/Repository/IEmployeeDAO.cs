using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeFace.DataAccess.Repository
{
    public interface IEmployeeDAO
    {
        List<Model.Employee> GetAll();

        Task<Model.Employee> CreateEmployee(Model.Employee employee);

        Task<Model.Employee> GetEmployeeById(int? id);

        Task<Model.Employee> UpdateEmployee(Model.Employee employee);
    }
}
