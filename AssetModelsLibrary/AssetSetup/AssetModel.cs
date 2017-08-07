using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetSetup
{
    /// <summary>
    /// Asset Model
    /// </summary>
    public class AssetModel
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
        /// Asset Manufacturer Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [DisplayName("Asset Manufacturer")]
        [Required(ErrorMessage = "Please Select an Asset Manufacturer")]
        public int AssetManufacturerId { get; set; }
        public virtual AssetManufacturer AssetManufacturer { get; set; }

        /// <summary>
        /// Asset Model Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Model Name")]
        [Required(ErrorMessage = "Please Insert Asset Model Name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset Model Short Name
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Model Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Model Code
        /// Required Propriety
        /// Unique By Asset Group and Manufacture
        /// Model Code Generated Automatically Formate(ShortName_ i.e. PAVLN_0001, BROBK_0001)
        /// </summary>
        [DisplayName("Model Code")]
        [Required(ErrorMessage = "Please Insert Model Code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// Asset Model Description
        /// </summary>
        public string Description { get; set; }
    }
}
