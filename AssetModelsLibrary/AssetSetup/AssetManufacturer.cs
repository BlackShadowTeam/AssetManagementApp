using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetSetup
{
    /// <summary>
    /// Asset Manufacturer
    /// </summary>
    public class AssetManufacturer
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asset Group Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [DisplayName("Asset Group")]
        [Required(ErrorMessage = "Please Select an Asset Group")]
        public int AssetGroupId { get; set; }
        public virtual AssetGroup AssetGroup { get; set; }

        /// <summary>
        /// Asset Manufacturer Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Manufacturer Name")]
        [Required(ErrorMessage = "Please Insert Asset Manufacturer Name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset Manufacturer Short Name
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Manufacturer Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Manufacturer Code
        /// Required Propriety
        /// Manufacturer Code Generated Automatically Formate(ShortName_ i.e. HP_0001, DELL_0001)
        /// </summary>
        [DisplayName("Manufacturer Code")]
        [Required(ErrorMessage = "Please Insert Manufacturer Code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// Asset Manufacturer Description
        /// </summary>
        public string Description { get; set; }
    }
}
