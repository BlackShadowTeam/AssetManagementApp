using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class BranchManager
    {
        private readonly BranchGetway _branchGetway = new BranchGetway();

        public bool IsShortNameExist(int organizationId, string shortName)
        {
            bool isShortNameExist = false;

            var aBranch = FindSingleBranchByOrgnationAndShortName(organizationId, shortName);
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

        public Branch FindBranchById(int id)
        {
            return _branchGetway.FindSingleBranchById(id);
        }

        public Branch FindSingleBranchByOrgnationAndShortName(int organizationId, string shortName)
        {
            return _branchGetway.FindSingleBranchByOrgnationAndShortName(organizationId, shortName);
        }

        public IEnumerable<Branch> GetAllBRanches()
        {
            return _branchGetway.GetAllBranches();
        }
    }
}
