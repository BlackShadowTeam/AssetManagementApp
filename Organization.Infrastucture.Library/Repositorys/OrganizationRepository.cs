using AssetDatabaseContextLibrary;
using Core.Repository.Library.Infrastucture;
using OrganizationModelsLibrary.Repositorys;
using System.Data.Entity;

namespace Organization.Infrastucture.Library.Repositorys
{
    public class OrganizationRepository : Repository<OrganizationModelsLibrary.Organization>, IOrganizationRepository
    {
        public OrganizationRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
