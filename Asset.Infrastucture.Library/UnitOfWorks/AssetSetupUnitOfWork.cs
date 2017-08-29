using Asset.Infrastucture.Library.Repositorys.AssetSetups;
using AssetDatabaseContextLibrary;
using AssetModelsLibrary.Repositorys.AssetSetup;
using AssetModelsLibrary.UnitOfWorks;

namespace Asset.Infrastucture.Library.UnitOfWorks
{
    public class AssetSetupUnitOfWork : IAssetSetupUnitOfWork
    {
        private readonly AssetDbContext _context;
        public AssetSetupUnitOfWork(AssetDbContext context)
        {
            _context = context;
            AssetGroup = new AssetGroupRepository(_context);
            AssetLocation = new AssetLocationRepository(_context);
            AssetManufacturer = new AssetManufacturerREpository(_context);
            AssetModel = new AssetModelRepository(_context);
            AssetType = new AssetTypeRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public IAssetGroupRepository AssetGroup { get; set; }
        public IAssetLocationRepository AssetLocation { get; set; }
        public IAssetManufacturerRepository AssetManufacturer { get; set; }
        public IAssetModelRepository AssetModel { get; set; }
        public IAssetTypeRepository AssetType { get; set; }
    }
}
