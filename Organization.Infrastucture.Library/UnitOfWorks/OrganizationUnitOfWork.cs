using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.Repositorys;
using OrganizationModelsLibrary.Repositorys;
using OrganizationModelsLibrary.UnitOfWorks;

namespace Organization.Infrastucture.Library.UnitOfWorks
{
    public class OrganizationUnitOfWork : IOrgnationUnitOfWork
    {
        private readonly AssetDbContext _context;

        public OrganizationUnitOfWork(AssetDbContext context)
        {
            _context = context;
            Orgnation = new OrganizationRepository(_context);
            Branch = new BranchRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public IOrganizationRepository Orgnation { get; set; }
        public IBranchRepository Branch { get; set; }
    }
}
