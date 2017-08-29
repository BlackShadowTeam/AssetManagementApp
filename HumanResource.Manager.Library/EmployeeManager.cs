using HumanResource.Getway.Library;
using HumanResourceModelsLibrary;
using System.Collections.Generic;

namespace HumanResource.Manager.Library
{
    public class EmployeeManager
    {
        private readonly EmployeeGetway _employeeGetway = new EmployeeGetway();

        public Employee GetEmployeeById(int id)
        {
            return _employeeGetway.GetEmployeeById(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeGetway.GetAllEmployees();
        }

        public Employee FindSingleEmployeeById(int id)
        {
            return _employeeGetway.FindSingleEmployeeById(id);
        }

        // Find
        public IEnumerable<Employee> FindEmployeesByContactNo(string contactNo)
        {
            return _employeeGetway.FindEmployeesByContactNo(contactNo);
        }

        // save
        public int Save(Employee aEmployee)
        {
            return _employeeGetway.Save(aEmployee);
        }

        public int SaveList(IEnumerable<Employee> employees)
        {
            return _employeeGetway.SaveList(employees);
        }

        // update
        public int Update(Employee aEmployee)
        {
            return _employeeGetway.Update(aEmployee);
        }

        // Delete
        public int Delete(Employee aEmployee)
        {
            return _employeeGetway.Delete(aEmployee);
        }

        public int DeleteList(IEnumerable<Employee> employees)
        {
            return _employeeGetway.DeleteList(employees);
        }
    }
}
