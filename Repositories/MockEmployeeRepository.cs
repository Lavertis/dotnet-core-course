using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            this._employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = Department.HR, Email = "mary@pragimtech.com"},
                new Employee() {Id = 2, Name = "John", Department = Department.IT, Email = "john@pragimtech.com"},
                new Employee() {Id = 3, Name = "Sam", Department = Department.IT, Email = "sam@pragimtech.com"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee AddEmployee(Employee employee)
        {
            var id = _employeeList.Max(e => e.Id) + 1;
            employee.Id = id;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }

            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                _employeeList.Remove(employee);
            return employee;
        }
    }
}