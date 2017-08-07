using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetSetup
{
    /// <summary>
    /// Asset Group
    /// </summary>
    public class AssetGroup
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asset Type Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [DisplayName("Asset Type")]
        [Required(ErrorMessage = "Please Select an Asset Type")]
        public int AssetTypeId { get; set; }
        public virtual AssetType AssetType { get; set; }

        /// <summary>
        /// Group Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Group Name")]
        [Required(ErrorMessage = "Please Insert Asset Group Name")]
        public string Name { get; set; }

        /// <summary>
        /// Group Short Name
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Group Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Group Code
        /// Required Propriety
        /// Group Code Generated Automatically Formate(ShortName_ i.e. LAPTP_0001, PRNTR_0001)
        /// </summary>
        [DisplayName("Group Code")]
        [Required(ErrorMessage = "Please Insert Group Code")]
        public string GroupCode { get; set; }
    }
}
