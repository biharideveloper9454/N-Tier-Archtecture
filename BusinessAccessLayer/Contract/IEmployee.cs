using ApICrudS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApICrudS.Contract
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee CreateEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        Employee  DeleteEmployee(int id);
        Employee UpdateEmployee(Employee employee);
    }
}
