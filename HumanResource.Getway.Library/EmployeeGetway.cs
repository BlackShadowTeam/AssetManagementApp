
using AssetDatabaseContextLibrary;
using HumanResource.Infrastucture.Library.UnitOfWorks;
using HumanResourceModelsLibrary;
using System.Collections.Generic;

namespace HumanResource.Getway.Library
{
    public class EmployeeGetway
    {
        private readonly EmployeeUnitOfWork _employeeUnitOfWork = new EmployeeUnitOfWork(new AssetDbContext());

        public Employee GetEmployeeById(int id)
        {
            return _employeeUnitOfWork.Employee.Get(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeUnitOfWork.Employee.GetAll();
        }

        public Employee FindSingleEmployeeById(int id)
        {
            return _employeeUnitOfWork.Employee.SingleOrDefault(c => c.Id == id);
        }

        // Find
        public IEnumerable<Employee> FindEmployeesByContactNo(string contactNo)
        {
            return _employeeUnitOfWork.Employee.Find(c => c.ContactNo == contactNo);
        }

        // save
        public int Save(Employee aEmployee)
        {
            _employeeUnitOfWork.Employee.Add(aEmployee);
            return _employeeUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<Employee> employees)
        {
            _employeeUnitOfWork.Employee.AddRange(employees);
            return _employeeUnitOfWork.Complete();
        }

        // update
        public int Update(Employee aEmployee)
        {
            _employeeUnitOfWork.Employee.Update(aEmployee);
            return _employeeUnitOfWork.Complete();
        }

        // Delete
        public int Delete(Employee aEmployee)
        {
            _employeeUnitOfWork.Employee.Remove(aEmployee);
            return _employeeUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<Employee> employees)
        {
            _employeeUnitOfWork.Employee.RemoveRange(employees);
            return _employeeUnitOfWork.Complete();
        }


    }
}
