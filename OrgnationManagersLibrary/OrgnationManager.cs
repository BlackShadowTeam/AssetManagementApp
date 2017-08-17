using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;

namespace OrgnationManagersLibrary
{
    public class OrgnationManager
    {
        private readonly OrgnationGetway _orgnationGetway=new OrgnationGetway();

        /// <summary>
        /// Check Orgnation is Exist or Not
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns></returns>
        public bool IsShortNameExist(string shortName)
        {
            bool isShortNameExist = false;
            var aOrgnation = FindOrganizationByShortName(shortName);
            if (aOrgnation!=null)
            {
                isShortNameExist = true;
            }
            return isShortNameExist;
        }


        /// <summary>
        /// Save Organation in Database
        /// </summary>
        /// <param name="aOrganization">Object</param>
        /// <returns></returns>
        public int Save(Organization aOrganization)
        {
            return _orgnationGetway.Save(aOrganization);
        }

        /// <summary>
        /// Find Organization By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Organization FindOrganizationById(int? id)
        {
            return _orgnationGetway.FindOrganizationById(id);
        }


        /// <summary>
        /// Find Organization By Short Name
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns></returns>
        public Organization FindOrganizationByShortName(string shortName)
        {
            return _orgnationGetway.FindOrganizationByShortName(shortName);
        }
    }
}
