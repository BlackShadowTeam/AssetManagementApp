using AssetDatabaseContextLibrary;
using Organization.Infrastucture.Library.Repositorys;
using OrganizationModelsLibrary.Repositorys;
using OrganizationModelsLibrary.UnitOfWorks;

namespace Organization.Infrastucture.Library.UnitOfWorks
{
    public class DepartmentDesignationUnitOfWork : IDepartmentDesignationUnitOfWork
    {
        private readonly AssetDbContext _context;

        public DepartmentDesignationUnitOfWork(AssetDbContext context)
        {
            _context = context;
            Department = new DepartmentRepository(_context);
            Designation = new DesignationRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public IDepartmentRepository Department { get; set; }
        public IDesignationRepository Designation { get; set; }
    }
}
