using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.UnitOfWorks;
using OrganizationModelsLibrary;
using System.Collections.Generic;

namespace OrgnationGetwaysLibrary
{
    public class BranchGetway
    {
        private readonly OrganizationUnitOfWork _organizationUnitOfWork = new OrganizationUnitOfWork(new AssetDbContext());


        public int Save(Branch aBranch)
        {
            _organizationUnitOfWork.Branch.Add(aBranch);
            return _organizationUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<Branch> branches)
        {
            _organizationUnitOfWork.Branch.AddRange(branches);
            return _organizationUnitOfWork.Complete();
        }

        public int Update(Branch aBranch)
        {
            _organizationUnitOfWork.Branch.Update(aBranch);
            return _organizationUnitOfWork.Complete();
        }


        public int Delete(Branch aBranch)
        {
            _organizationUnitOfWork.Branch.Remove(aBranch);
            return _organizationUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<Branch> branches)
        {
            _organizationUnitOfWork.Branch.RemoveRange(branches);
            return _organizationUnitOfWork.Complete();
        }

        public Branch GetBranch(int id)
        {
            return _organizationUnitOfWork.Branch.Get(id);
        }

        public Branch FindSingleBranchById(int id)
        {
            return _organizationUnitOfWork.Branch.SingleOrDefault(c => c.Id == id);
        }

        public Branch FindSingleBranchByOrgnationAndShortName(int organizationId, string shortName)
        {
            return
                _organizationUnitOfWork.Branch.SingleOrDefault(
                    c => c.OrganizationId == organizationId && c.ShortName == shortName);
        }

        public IEnumerable<Branch> FindBranchesByName(string name)
        {
            return _organizationUnitOfWork.Branch.Find(c => c.Name == name || c.ShortName == name);
        }


        public IEnumerable<Branch> GetAllBranches()
        {
            return _organizationUnitOfWork.Branch.GetAll();
        }
    }
}
