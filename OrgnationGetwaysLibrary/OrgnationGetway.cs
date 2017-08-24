using AssetDatabaseContextLibrary.DatabaseContexts;
using OrganizationModelsLibrary;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OrgnationGetwaysLibrary
{
    public class OrgnationGetway
    {
        private readonly AssetDbContext db = new AssetDbContext();

        public int Save(Organization aOrganization)
        {
            db.Organizations.Add(aOrganization);
            return db.SaveChanges();
        }

        public int Update(Organization aOrganization)
        {
            db.Entry(aOrganization).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public Organization FindOrganizationById(int? id)
        {
            var aOrganization = db.Organizations.FirstOrDefault(c => c.Id == id);
            return aOrganization;
        }

        public Organization FindOrganizationByName(string name)
        {
            var aOrgnation = db.Organizations.FirstOrDefault(organization => organization.Name == name);
            return aOrgnation;
        }

        public Organization FindOrganizationByShortName(string shortName)
        {
            var aOrgnation = db.Organizations.FirstOrDefault(organization => organization.ShortName == shortName);
            return aOrgnation;
        }

        public List<Organization> GetOrganizationsByNameOrShortName(string searchInput)
        {
            var aOrgnation = db.Organizations.Where(c => c.Name == searchInput || c.ShortName == searchInput).ToList();
            return aOrgnation;
        }

        public List<Organization> GetAllOrganization()
        {
            return db.Organizations.ToList();
        }
    }
}
