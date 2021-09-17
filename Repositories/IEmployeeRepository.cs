using System.Collections;
using System.Collections.Generic;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployees();

        Employee AddEmployee(Employee employee);
    }
}
