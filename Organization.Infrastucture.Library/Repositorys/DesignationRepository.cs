﻿using AssetDatabaseContextLibrary;
using Core.Repository.Library.Infrastucture;
using OrganizationModelsLibrary;
using OrganizationModelsLibrary.Repositorys;
using System.Data.Entity;

namespace Organization.Infrastucture.Library.Repositorys
{
    public class DesignationRepository : Repository<Designation>, IDesignationRepository
    {
        public DesignationRepository(DbContext context)
            : base(context)
        {
        }

        public AssetDbContext AssetDbContext
        {
            get { return Context as AssetDbContext; }
        }
    }
}
