using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrganizationModelsLibrary
{
    /// <summary>
    /// Organization Department Designations
    /// </summary>
    public class Designation
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Department Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [DisplayName("Department")]
        [Required(ErrorMessage = "Please Select a Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        /// <summary>
        /// Designation Name
        /// Required Propriety
        /// Unique by Department
        /// </summary>
        [DisplayName("Designation")]
        [Required(ErrorMessage = "Please Insert Designation")]
        public string Name { get; set; }

        /// <summary>
        /// Designation Short Name
        /// Required Propriety
        /// Unique Propriety By Department
        /// </summary>
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Please Insert Designation Short Name")]
        public string ShortName { get; set; }
    }
}
