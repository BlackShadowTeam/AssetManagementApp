using AssetDatabaseContextLibrary;
using OrganizationModelsLibrary;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OrgnationGetwaysLibrary
{
    public class BranchGetway
    {
        private readonly AssetDbContext db = new AssetDbContext();

        public int Save(Branch aBranch)
        {
            db.Branches.Add(aBranch);
            return db.SaveChanges();
        }

        public int Update(Branch aBranch)
        {
            db.Entry(aBranch).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public Branch FindBranchById(int? id)
        {
            var aBranch = db.Branches.FirstOrDefault(c => c.Id == id);
            return aBranch;
        }

        public Branch FindBranchByName(string name)
        {
            var aBranch = db.Branches.FirstOrDefault(branch => branch.Name == name);
            return aBranch;
        }

        public Branch FindBranchByShortName(string shortName)
        {
            var aBranch = db.Branches.FirstOrDefault(branch => branch.ShortName == shortName);
            return aBranch;
        }

        public Branch FindBranchByOrganizationAndShortName(int? organizationId, string shortName)
        {
            var aBranch = db.Branches.FirstOrDefault(c => c.OrganizationId == organizationId && c.ShortName == shortName);
            return aBranch;
        }
        public List<Branch> GetBranchByNameOrShortName(string searchInput)
        {
            var branchList = db.Branches.Where(c => c.Name == searchInput || c.ShortName == searchInput).ToList();
            return branchList;
        }

        public List<Branch> GetBranchesByOrganizationId(int? organizationId)
        {
            var branchList = db.Branches.Where(c => c.OrganizationId == organizationId).ToList();
            return branchList;
        }

        public List<Branch> GetAllBRanches()
        {
            return db.Branches.ToList();
        }
    }
}
