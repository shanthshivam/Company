using Company.Models;

namespace Company.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee> GetEmployee(int id);
    }
}
