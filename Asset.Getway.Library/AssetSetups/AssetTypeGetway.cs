using Asset.Infrastucture.Library.UnitOfWorks;
using AssetDatabaseContextLibrary;
using AssetModelsLibrary.AssetSetup;
using System.Collections.Generic;

namespace Asset.Getway.Library.AssetSetups
{
    public class AssetTypeGetway
    {
        private readonly AssetSetupUnitOfWork _assetSetupUnitOfWork = new AssetSetupUnitOfWork(new AssetDbContext());

        public AssetType GetAssetTypeById(int id)
        {
            return _assetSetupUnitOfWork.AssetType.Get(id);
        }

        public IEnumerable<AssetType> GetAllAssetTypes()
        {
            return _assetSetupUnitOfWork.AssetType.GetAll();
        }

        // find
        public IEnumerable<AssetType> FindAssetTypesByName(string name)
        {
            return _assetSetupUnitOfWork.AssetType.Find(c => c.Name == name || c.ShortName == name);
        }

        public AssetType FindSingleAssetTypebyId(int id)
        {
            return _assetSetupUnitOfWork.AssetType.SingleOrDefault(c => c.Id == id);
        }

        public AssetType FindSingleAssetTypebyShortName(string shortName)
        {
            return _assetSetupUnitOfWork.AssetType.SingleOrDefault(c => c.ShortName == shortName);
        }


        // save
        public int Save(AssetType assetType)
        {
            _assetSetupUnitOfWork.AssetType.Add(assetType);
            return _assetSetupUnitOfWork.Complete();
        }

        public int SaveList(IEnumerable<AssetType> assetTypes)
        {
            _assetSetupUnitOfWork.AssetType.AddRange(assetTypes);
            return _assetSetupUnitOfWork.Complete();
        }

        // update
        public int Update(AssetType assetType)
        {
            _assetSetupUnitOfWork.AssetType.Update(assetType);
            return _assetSetupUnitOfWork.Complete();
        }

        // delete 
        public int Delete(AssetType assetType)
        {
            _assetSetupUnitOfWork.AssetType.Remove(assetType);
            return _assetSetupUnitOfWork.Complete();
        }

        public int DeleteList(IEnumerable<AssetType> assetTypes)
        {
            _assetSetupUnitOfWork.AssetType.RemoveRange(assetTypes);
            return _assetSetupUnitOfWork.Complete();
        }
    }
}
