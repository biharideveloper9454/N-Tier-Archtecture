using ApICrudS.Contract;
using ApICrudS.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApICrudS.Repository.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeDataOperation dataOperation;

        public EmployeeService(ApplicationContext context, EmployeeDataOperation dataOperation = null)
        {
          
            this.dataOperation = dataOperation;
        }

        public Employee CreateEmployee(Employee employee)
        {
            var result = dataOperation.CreateEmployee(employee);
            return result;

        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dataOperation.DeleteEmployee(id);
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = dataOperation.GetEmployeeById(id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            var emp = dataOperation.GetEmployees();
            return emp;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = dataOperation.UpdateEmployee(employee);
            return emp;
        }
    }
}
