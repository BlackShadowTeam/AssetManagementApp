﻿using AssetDatabaseContextLibrary;
using AssetModelsLibrary.AssetEntrys;
using AssetModelsLibrary.Repositorys.AssetEntrys;
using Core.Repository.Library.Infrastucture;
using System.Data.Entity;

namespace Asset.Infrastucture.Library.Repositorys.AssetEntys
{
    public class AssetEntryRepository : Repository<AssetEntry>, IAssetEntryRepository
    {
        public AssetEntryRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
