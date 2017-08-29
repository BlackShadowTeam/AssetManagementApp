using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.UnitOfWorks;
using OrganizationModelsLibrary;
using System.Collections.Generic;

namespace OrgnationGetwaysLibrary
{
    public class DesignationGetway
    {
        private readonly DepartmentDesignationUnitOfWork _departmentDesignationUnitOfWork = new DepartmentDesignationUnitOfWork(new AssetDbContext());

        public Designation GetDesignationById(int id)
        {
            return _departmentDesignationUnitOfWork.Designation.Get(id);
        }

        public Designation FindSingleDesignationbyId(int id)
        {
            return _departmentDesignationUnitOfWork.Designation.SingleOrDefault(c => c.Id == id);
        }

        public Designation FindSingleDesignationByShortName(string shortName)
        {
            return _departmentDesignationUnitOfWork.Designation.SingleOrDefault(c => c.ShortName == shortName);
        }

        public IEnumerable<Designation> GetAllDesignations()
        {
            return _departmentDesignationUnitOfWork.Designation.GetAll();
        }

        // find
        public IEnumerable<Designation> FindDesignationsByName(string name)
        {
            return _departmentDesignationUnitOfWork.Designation.Find(c => c.Name == name || c.ShortName == name);
        }

        // save
        public int Save(Designation aDesignation)
        {
            _departmentDesignationUnitOfWork.Designation.Add(aDesignation);
            return _departmentDesignationUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<Designation> designations)
        {
            _departmentDesignationUnitOfWork.Designation.AddRange(designations);
            return _departmentDesignationUnitOfWork.Complete();
        }

        // Update
        public int Update(Designation aDesignation)
        {
            _departmentDesignationUnitOfWork.Designation.Update(aDesignation);
            return _departmentDesignationUnitOfWork.Complete();
        }

        // Delete
        public int Delete(Designation aDesignation)
        {
            _departmentDesignationUnitOfWork.Designation.Remove(aDesignation);
            return _departmentDesignationUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<Designation> designations)
        {
            _departmentDesignationUnitOfWork.Designation.RemoveRange(designations);
            return _departmentDesignationUnitOfWork.Complete();
        }
    }
}
