using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OrganizationModelsLibrary;

namespace HumanResourceModelsLibrary
{
    /// <summary>
    /// Organization Employee
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        [Required]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }


        public string Email { get; set; }
        public string Address { get; set; }
        public byte[] Image{ get; set; }
        public string Code { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

    }
}
