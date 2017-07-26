using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrganizationModelsLibrary
{
    /// <summary>
    /// Organization Department
    /// </summary>
    public class Department
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
        /// Department Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Please Insert Department Name")]
        public string Name { get; set; }

        /// <summary>
        /// Department Short Name
        /// Required Propriety
        /// Unique Propriety By Organization
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Department Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Department Code
        /// Required Propriety
        /// Unique by Oragnization
        /// Department Code Generated Automatically Formate(OrganizationShortName_DepartmentShortName i.e. BITM_HR, BASIS_IT)
        /// </summary>
        [DisplayName("Department Code")]
        [Required(ErrorMessage = "Please Insert Department Code")]
        public string DepartmentCode { get; set; }

    }
}
