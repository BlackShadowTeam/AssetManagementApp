using AssetModelsLibrary.AssetSetup;
using OrganizationModelsLibrary;
using System.Data.Entity;

namespace AssetDatabaseContextLibrary
{
    public class AssetDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<AssetLocation> AssetLocations { get; set; }

    }
}
