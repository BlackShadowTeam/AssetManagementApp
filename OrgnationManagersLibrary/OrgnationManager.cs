
using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class OrgnationManager
    {
        private readonly OrgnationGetway _orgnationGetway = new OrgnationGetway();


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

        public int Save(Organization aOrganization)
        {
            return _orgnationGetway.Save(aOrganization);
        }

        public int Update(Organization aOrganization)
        {
            return _orgnationGetway.Update(aOrganization);
        }

        public Organization FindOrganizationById(int? id)
        {
            return _orgnationGetway.FindOrganizationById(id);
        }

        public Organization FindOrganizationByName(string name)
        {
            return _orgnationGetway.FindOrganizationByName(name);
        }

        public Organization FindOrganizationByShortName(string shortName)
        {
            return _orgnationGetway.FindOrganizationByShortName(shortName);
        }

        public List<Organization> GetOrganizationsByNameOrShortName(string searchInput)
        {
            return _orgnationGetway.GetOrganizationsByNameOrShortName(searchInput);
        }

        public List<Organization> GetAllOrganization()
        {
            return _orgnationGetway.GetAllOrganization();
        }
    }
}
