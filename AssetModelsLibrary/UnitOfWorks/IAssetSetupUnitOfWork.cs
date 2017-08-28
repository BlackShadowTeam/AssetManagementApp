using AssetModelsLibrary.Repositorys.AssetSetup;
using Core.Repository.Library.UnitOfWork;

namespace AssetModelsLibrary.UnitOfWorks
{
    public interface IAssetSetupUnitOfWork : IUnitOfWork
    {
        IAssetGroupRepository AssetGroup { get; set; }
        IAssetLocationRepository AssetLocation { get; set; }
        IAssetManufacturerRepository AssetManufacturer { get; set; }
        IAssetModelRepository AssetModel { get; set; }
        IAssetTypeRepository AssetType { get; set; }
    }
}
