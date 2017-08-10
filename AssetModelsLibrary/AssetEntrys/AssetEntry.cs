using System.ComponentModel.DataAnnotations;
using AssetModelsLibrary.AssetSetup;
using OrganizationModelsLibrary;

namespace AssetModelsLibrary.AssetEntrys
{
    /// <summary>
    /// Asset Entry/ Registration
    /// </summary>
    public class AssetEntry
    {
        public int Id { get; set; }

        /// <summary>
        /// Organization Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        /// <summary>
        /// Branch Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        /// <summary>
        /// Asset Location Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Asset Location")]
        public int AssetLocationId { get; set; }
        public virtual AssetLocation AssetLocation { get; set; }

        /// <summary>
        /// Asset Type Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Asset Type")]
        public int AssetTypeId { get; set; }
        public virtual AssetType AssetType { get; set; }

        /// <summary>
        /// Asset Group Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Asset Group")]
        public int AssetGroupId { get; set; }
        public virtual AssetGroup AssetGroup { get; set; }

        /// <summary>
        /// Asset Manufacture Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Manufacture")]
        public int AssetManufacturerId { get; set; }
        public virtual AssetManufacturer AssetManufacturer { get; set; }

        /// <summary>
        /// Asset Model Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Asset Model")]
        public int AssetModelId { get; set; }
        public virtual AssetModel AssetModel { get; set; }

        /// <summary>
        /// Asset Id
        /// Required Propriety
        /// Asset Id Generated Automatically Formate( [Asset Type Name (1)][Asset Group Name (1)] [Asset Model Name (3)][6 digit numeric] example, CLPRO000001 - [Computer] [Laptop] [ProBook] [000001])
        /// </summary>
        [Required]
        [Display(Name = "Asset Id")]
        public string AssetId { get; set; }

        /// <summary>
        /// Asset Name
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset Serial No
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Serial No")]
        public int SerialNo { get; set; }

        /// <summary>
        /// Asset Status
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        /// <summary>
        /// Asset Attachment File
        /// Required Propriety
        /// </summary>
        public byte[] Attachment { get; set; }

    }
}
