using AssetDbContextLibrary;
using OrganizationModelsLibrary;

namespace OrgnationGetwaysLibrary
{
    public class OrgnationGetway
    {
        private readonly AssetTrackingDbContext _dbContext=new AssetTrackingDbContext();

        /// <summary>
        /// Save Organation in Database
        /// </summary>
        /// <param name="aOrganization">Object</param>
        /// <returns></returns>
        public int Save(Organization aOrganization)
        {
            _dbContext.Organizations.Add(aOrganization);
            return _dbContext.SaveChanges();
        }


        /// <summary>
        /// Find Organization By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Organization FindOrganizationById(int? id)
        {
            Organization aOrganization = _dbContext.Organizations.Find(id);
            return aOrganization;
        }

        /// <summary>
        /// Find Organization By Short Name
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns></returns>
        public Organization FindOrganizationByShortName(string shortName)
        {
            Organization aOrganization = _dbContext.Organizations.Find(shortName);
            return aOrganization;
        }
    }
}
