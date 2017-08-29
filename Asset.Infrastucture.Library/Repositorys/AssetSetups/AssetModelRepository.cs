using AssetDatabaseContextLibrary;
using AssetModelsLibrary.AssetSetup;
using AssetModelsLibrary.Repositorys.AssetSetup;
using Core.Repository.Library.Infrastucture;
using System.Data.Entity;

namespace Asset.Infrastucture.Library.Repositorys.AssetSetups
{
    public class AssetModelRepository : Repository<AssetModel>, IAssetModelRepository
    {
        public AssetModelRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
