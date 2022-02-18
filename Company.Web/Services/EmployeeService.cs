using Company.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Company.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }
    }
}