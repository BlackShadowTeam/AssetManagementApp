
using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class DepartmentManager
    {
        private readonly DepartmentGetway _departmentGetway = new DepartmentGetway();

        public Department GetDepartmentById(int id)
        {
            return _departmentGetway.GetDepartmentById(id);
        }

        public Department FindSingleDepartmentById(int id)
        {
            return _departmentGetway.FindSingleDepartmentById(id);
        }

        public Department FindSingleDepartmentByName(string name)
        {
            return _departmentGetway.FindSingleDepartmentByName(name);
        }

        public Department FindSingleDepartmentByShortName(string shortName)
        {
            return _departmentGetway.FindSingleDepartmentByShortName(shortName);
        }

        // search
        public IEnumerable<Department> FindDepartments(string name)
        {
            return _departmentGetway.FindDepartments(name);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentGetway.GetAllDepartments();
        }

        // save
        public int Save(Department aDepartment)
        {
            return _departmentGetway.Save(aDepartment);
        }

        public int SaveList(IEnumerable<Department> departments)
        {
            return _departmentGetway.SaveList(departments);
        }

        // update
        public int Update(Department aDepartment)
        {
            return _departmentGetway.Update(aDepartment);
        }

        // Delete
        public int Delete(Department aDepartment)
        {
            return _departmentGetway.Delete(aDepartment);
        }

        public int DeleteList(IEnumerable<Department> departments)
        {
            return _departmentGetway.DeleteList(departments);
        }
    }
}
