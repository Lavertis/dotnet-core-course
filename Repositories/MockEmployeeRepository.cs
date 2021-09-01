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
                new Employee() {Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com"},
                new Employee() {Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com"},
                new Employee() {Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}