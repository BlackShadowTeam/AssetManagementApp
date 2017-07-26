using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OrganizationModelsLibrary;

namespace AssetModelsLibrary
{
    public class AssetLocation
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Organization Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [DisplayName("Organization")]
        [Required(ErrorMessage = "Please Select an Organization")]
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        /// <summary>
        /// Branch Table Id
        /// Foreign Key 
        /// Required Propriety
        /// Lode By OrganizationId
        /// </summary>
        [DisplayName("Branch")]
        [Required(ErrorMessage = "Please Select a Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        /// <summary>
        /// Location Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Location Name")]
        [Required(ErrorMessage = "Please Insert Branch Name")]
        public string Name { get; set; }

        /// <summary>
        /// Asset Location Short Name
        /// Required Propriety
        /// Unique Propriety 
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Location Code
        /// Required Propriety
        /// Location Code Generated Automatically Formate(BranchCode_LocationShortName i.e. BITM_DHK_L401, BASIS_DHK_S001)
        /// </summary>
        [DisplayName("Location Code")]
        [Required(ErrorMessage = "Please Insert Location Code")]
        public string BranchCode { get; set; }
    }
}
