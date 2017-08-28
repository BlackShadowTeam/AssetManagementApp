using AssetDatabaseContextLibrary;
using HumanResource.Infrastucture.Library.Repositorys;
using HumanResourceModelsLibrary.Repositorys;
using HumanResourceModelsLibrary.UnitOfWorks;

namespace HumanResource.Infrastucture.Library.UnitOfWorks
{
    public class EmployeeUnitOfWork : IEmployeeUnitOfWork
    {
        private readonly AssetDbContext _context;

        public EmployeeUnitOfWork(AssetDbContext context)
        {
            _context = context;
            Employee = new EmployeeRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public IEmployeeRepository Employee { get; set; }
    }
}
