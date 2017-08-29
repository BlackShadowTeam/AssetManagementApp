using AssetDatabaseContextLibrary;
using AssetModelsLibrary.AssetEntrys;
using AssetModelsLibrary.Repositorys.AssetEntrys;
using Core.Repository.Library.Infrastucture;
using System.Data.Entity;

namespace Asset.Infrastucture.Library.Repositorys.AssetEntys
{
    public class FinanceRepository : Repository<Finance>, IFinanceRepository
    {
        public FinanceRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
