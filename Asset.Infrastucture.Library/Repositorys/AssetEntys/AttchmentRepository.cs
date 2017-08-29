using AssetDatabaseContextLibrary;
using AssetModelsLibrary.AssetEntrys;
using AssetModelsLibrary.Repositorys.AssetEntrys;
using Core.Repository.Library.Infrastucture;
using System.Data.Entity;

namespace Asset.Infrastucture.Library.Repositorys.AssetEntys
{
    public class AttchmentRepository : Repository<Attchment>, IAttchmentRepository
    {
        public AttchmentRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
