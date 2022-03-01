using ApICrudS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class EmployeeDataOperation
    {
        private  ApplicationContext context;

        public EmployeeDataOperation()
        {
            context = new ApplicationContext();
        }
        public Employee CreateEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;

        }

        public Employee DeleteEmployee(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);

            context.Employees.Remove(emp);
            context.SaveChanges();
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            var emp = context.Employees.ToList();
            return emp;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = context.Employees.Update(employee);
            context.Employees.Update(employee);
            context.SaveChanges();
            return employee;
        }
    }
}
