using System.ComponentModel.DataAnnotations;

namespace OrganizationModelsLibrary
{
    /// <summary>
    /// Organization Vandor
    /// </summary>
    public class Vendor
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Vendor Full Name
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Vendor Short Name
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Short Name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Vendor Contact No
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        /// <summary>
        /// Vendor Email
        /// </summary>
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Vendor Address
        /// </summary>
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// Vendor Description
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
