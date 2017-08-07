using System.ComponentModel.DataAnnotations;
using OrganizationModelsLibrary;

namespace HumanResourceModelsLibrary
{
    /// <summary>
    /// Organization Employee
    /// </summary>
    public class Employee
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
        /// Person First Name
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Perosn Last Name
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Person Contact No
        /// Required Propriety
        /// Unique Propriety
        /// </summary>
        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        /// <summary>
        /// Person Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Person Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Person Image
        /// </summary>
        public byte[] Image{ get; set; }

        /// <summary>
        /// Person Code
        /// Auto Generationg
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Person Department Where he/she work
        /// Required Propriety
        /// Department Table Id
        /// Foreign Key 
        /// </summary>
        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        /// <summary>
        /// Person Designation
        /// Required Propriety
        /// Designation Table Id
        /// Foreign Key
        /// </summary>
        [Required]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

    }
}
