using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetSetup
{
    /// <summary>
    /// Asset Type
    /// </summary>
    public class AssetType
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asset Type Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Type Name")]
        [Required(ErrorMessage = "Please Insert Asset Type Name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset Type Short Name
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Asset Type Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Asset Type Code
        /// Required Propriety
        /// Asset Type Code Generated Automatically Formate(AssetTypeShortName_ i.e. ELCTX_0001, FURNT_0001)
        /// </summary>
        [DisplayName("Type Code")]
        [Required(ErrorMessage = "Please Insert Asset Type Code")]
        public string AssetTypeCode { get; set; }
    }
}
