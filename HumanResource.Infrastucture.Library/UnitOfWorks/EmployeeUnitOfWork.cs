using AssetDatabaseContextLibrary;
using HumanResource.Infrastucture.Library.Repositorys;
using HumanResourceModelsLibrary.Repositorys;
using HumanResourceModelsLibrary.UnitOfWorks;

namespace HumanResource.Infrastucture.Library.UnitOfWorks
{
    public class EmployeeUnitOfWork : IEmployeeUnitOfWork
    {
        public readonly AssetDbContext _Context;

        public EmployeeUnitOfWork(AssetDbContext context)
        {
            _Context = context;
            Employee = new EmployeeRepository(_Context);
        }
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int Complete()
        {
            return _Context.SaveChanges();
        }

        public IEmployeeRepository Employee { get; set; }
    }
}
