using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
