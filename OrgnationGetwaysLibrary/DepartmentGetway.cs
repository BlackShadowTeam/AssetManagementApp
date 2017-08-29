
using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.UnitOfWorks;
using OrganizationModelsLibrary;
using System.Collections.Generic;

namespace OrgnationGetwaysLibrary
{
    public class DepartmentGetway
    {
        private readonly DepartmentDesignationUnitOfWork _departmentDesignationUnitOfWork = new DepartmentDesignationUnitOfWork(new AssetDbContext());


        public Department GetDepartmentById(int id)
        {
            return _departmentDesignationUnitOfWork.Department.Get(id);

        }

        public Department FindSingleDepartmentById(int id)
        {
            return _departmentDesignationUnitOfWork.Department.SingleOrDefault(c => c.Id == id);
        }

        public Department FindSingleDepartmentByName(string name)
        {
            return _departmentDesignationUnitOfWork.Department.SingleOrDefault(c => c.Name == name);
        }

        public Department FindSingleDepartmentByShortName(string shortName)
        {
            return _departmentDesignationUnitOfWork.Department.SingleOrDefault(c => c.ShortName == shortName);
        }

        // search
        public IEnumerable<Department> FindDepartments(string name)
        {
            return _departmentDesignationUnitOfWork.Department.Find(c => c.Name == name || c.ShortName == name);
        }


        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentDesignationUnitOfWork.Department.GetAll();
        }
        // save
        public int Save(Department aDepartment)
        {
            _departmentDesignationUnitOfWork.Department.Add(aDepartment);
            return _departmentDesignationUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<Department> departments)
        {
            _departmentDesignationUnitOfWork.Department.AddRange(departments);
            return _departmentDesignationUnitOfWork.Complete();
        }

        // update
        public int Update(Department aDepartment)
        {
            _departmentDesignationUnitOfWork.Department.Update(aDepartment);
            return _departmentDesignationUnitOfWork.Complete();
        }


        // Delete
        public int Delete(Department aDepartment)
        {
            _departmentDesignationUnitOfWork.Department.Remove(aDepartment);
            return _departmentDesignationUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<Department> departments)
        {
            _departmentDesignationUnitOfWork.Department.RemoveRange(departments);
            return _departmentDesignationUnitOfWork.Complete();
        }

    }
}
