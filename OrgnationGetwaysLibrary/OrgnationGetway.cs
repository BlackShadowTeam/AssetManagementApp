using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.UnitOfWorks;
using System.Collections.Generic;

namespace OrgnationGetwaysLibrary
{
    public class OrgnationGetway
    {
        private readonly OrgnationUnitOfWork _orgnationUnitOfWork = new OrgnationUnitOfWork(new AssetDbContext());

        public OrganizationModelsLibrary.Organization GetOrganizationById(int id)
        {
            return _orgnationUnitOfWork.Orgnation.Get(id);
        }

        public OrganizationModelsLibrary.Organization FindOrganizationById(int id)
        {
            return _orgnationUnitOfWork.Orgnation.SingleOrDefault(c => c.Id == id);
        }

        public OrganizationModelsLibrary.Organization FindOrganizationByShortName(string shortName)
        {
            return _orgnationUnitOfWork.Orgnation.SingleOrDefault(c => c.ShortName == shortName);
        }

        public IEnumerable<OrganizationModelsLibrary.Organization> FindOrganizationByName(string name)
        {
            return _orgnationUnitOfWork.Orgnation.Find(c => c.Name == name || c.ShortName == name);
        }


        public IEnumerable<OrganizationModelsLibrary.Organization> GetAllOrganizations()
        {
            return _orgnationUnitOfWork.Orgnation.GetAll();
        }


        // save
        public int Save(OrganizationModelsLibrary.Organization aOrganization)
        {
            _orgnationUnitOfWork.Orgnation.Add(aOrganization);
            return _orgnationUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<OrganizationModelsLibrary.Organization> organizations)
        {
            _orgnationUnitOfWork.Orgnation.AddRange(organizations);
            return _orgnationUnitOfWork.Complete();
        }

        // update
        public int Update(OrganizationModelsLibrary.Organization aOrganization)
        {
            _orgnationUnitOfWork.Orgnation.Update(aOrganization);
            return _orgnationUnitOfWork.Complete();
        }

        //delete
        public int Delete(OrganizationModelsLibrary.Organization aOrganization)
        {
            _orgnationUnitOfWork.Orgnation.Remove(aOrganization);
            return _orgnationUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<OrganizationModelsLibrary.Organization> organizations)
        {
            _orgnationUnitOfWork.Orgnation.RemoveRange(organizations);
            return _orgnationUnitOfWork.Complete();
        }
    }
}
