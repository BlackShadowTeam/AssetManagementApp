using OrganizationModelsLibrary;
using System.Data.Entity;

namespace AssetDatabaseContextLibrary.DatabaseContexts
{
    public class AssetDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
    }
}
