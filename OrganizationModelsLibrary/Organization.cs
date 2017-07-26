using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrganizationModelsLibrary
{
    /// <summary>
    /// Company Basic Information
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Organization Name
        /// Required Propriety
        /// </summary>
        [DisplayName("Organization Name")]
        [Required(ErrorMessage = "Please Insert Organization Name")]
        public string Name { get; set; }

        /// <summary>
        /// Organization Short Name
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Organization Location
        /// </summary>
        [DisplayName("Location")]
        public string Location { get; set; }

        /// <summary>
        /// Organization Description
        /// </summary>
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
