using System.Data.Entity;
using OrganizationModelsLibrary;

namespace AssetManagementUI.Models
{
    public class AssetTrackingDbContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<AssetLocation> AssetLocations { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Designation> Designations { get; set; }


        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Vendor> Vendors { get; set; }

        //public DbSet<AssetType> AssetTypes { get; set; }
        //public DbSet<AssetGroup> AssetGroups { get; set; }
        //public DbSet<AssetManufacturer> AssetManufacturers { get; set; }
        //public DbSet<AssetModel> AssetModels { get; set; }


        //public DbSet<AssetEntry> AssetEntries { get; set; }
    }
}
