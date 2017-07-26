using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrganizationModelsLibrary
{
    /// <summary>
    /// Organization Branch
    /// </summary>
    public class Branch
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
        /// Branch Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Branch Name")]
        [Required(ErrorMessage = "Please Insert Branch Name")]
        public string Name { get; set; }

        /// <summary>
        /// Branch Short Name
        /// Required Propriety
        /// Unique Propriety By Organization
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Branch Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Branch Code
        /// Required Propriety
        /// Unique By Organization
        /// Branch Code Generated Automatically Formate(OrganizationShortName_BranchShortName i.e. BITM_DHK, BASIS_DHK)
        /// </summary>
        [DisplayName("Branch Code")]
        [Required(ErrorMessage = "Please Insert Branch Code")]
        public string BranchCode { get; set; }
    }
}
