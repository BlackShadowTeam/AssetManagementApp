using AssetDatabaseContextLibrary;
using Core.Repository.Library.Infrastucture;
using HumanResourceModelsLibrary;
using HumanResourceModelsLibrary.Repositorys;
using System.Data.Entity;

namespace HumanResource.Infrastucture.Library.Repositorys
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
