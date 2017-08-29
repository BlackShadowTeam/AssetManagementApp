using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class OrganizationManager
    {
        private readonly OrganizationGetway _orgnationGetway = new OrganizationGetway();


        public bool IsShortNameExist(string shortName)
        {
            bool isShortNameExist = false;
            var aOrgnation = FindOrganizationByShortName(shortName);
            if (aOrgnation != null)
            {
                isShortNameExist = true;
            }
            return isShortNameExist;
        }

        public Organization FindOrganizationById(int id)
        {
            return _orgnationGetway.FindOrganizationById(id);
        }

        public Organization FindOrganizationByShortName(string shortName)
        {
            return _orgnationGetway.FindOrganizationByShortName(shortName);
        }

        public IEnumerable<Organization> FindOrganizationByName(string name)
        {
            return _orgnationGetway.FindOrganizationByName(name);
        }

        public IEnumerable<Organization> GetAllOrganization()
        {
            return _orgnationGetway.GetAllOrganizations();
        }


        public int Save(Organization aOrganization)
        {
            return _orgnationGetway.Save(aOrganization);
        }

        public int SaveList(IEnumerable<Organization> organizations)
        {
            return _orgnationGetway.SaveList(organizations);
        }

        public int Update(Organization aOrganization)
        {
            return _orgnationGetway.Update(aOrganization);
        }

        public int Delete(Organization aOrganization)
        {
            return _orgnationGetway.Delete(aOrganization);
        }

        public int DeleteList(IEnumerable<Organization> organizations)
        {
            return _orgnationGetway.DeleteList(organizations);
        }
    }
}
