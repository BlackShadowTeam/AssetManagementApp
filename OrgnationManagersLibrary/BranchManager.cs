using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class BranchManager
    {
        private readonly BranchGetway _branchGetway = new BranchGetway();

        public bool IsShortNameExist(int? organizationId, string shortName)
        {
            bool isShortNameExist = false;

            var aBranch = FindBranchByOrganizationAndShortName(organizationId, shortName);
            if (aBranch != null)
            {
                isShortNameExist = true;
            }
            return isShortNameExist;
        }

        public int Save(Branch aBranch)
        {
            return _branchGetway.Save(aBranch);
        }

        public int Update(Branch aBranch)
        {
            return _branchGetway.Update(aBranch);
        }

        public Branch FindBranchById(int? id)
        {
            return _branchGetway.FindBranchById(id);
        }

        public Branch FindBranchByName(string name)
        {
            return _branchGetway.FindBranchByName(name);
        }

        public Branch FindBranchByShortName(string shortName)
        {
            return _branchGetway.FindBranchByShortName(shortName);
        }

        public Branch FindBranchByOrganizationAndShortName(int? organizationId, string shortName)
        {
            return _branchGetway.FindBranchByOrganizationAndShortName(organizationId, shortName);
        }
        public List<Branch> GetBranchByNameOrShortName(string searchInput)
        {
            return _branchGetway.GetBranchByNameOrShortName(searchInput);
        }

        public List<Branch> GetBranchesByOrganizationId(int? organizationId)
        {
            return _branchGetway.GetBranchesByOrganizationId(organizationId);
        }

        public List<Branch> GetAllBRanches()
        {
            return _branchGetway.GetAllBRanches();
        }
    }
}
