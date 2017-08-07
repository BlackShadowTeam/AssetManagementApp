using System;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetEntry
{
    public class ServiceOrRepairing
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asstet Entry Table Id
        /// Forgin Key
        /// Asset Table Master and ServiceOrRepairing Table Details
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(AutoGenerateField = false)]
        public int AssetEntryId { get; set; }
        public virtual AssetEntry AssetEntry { get; set; }

        /// <summary>
        /// Description
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Service Date
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Srvice Date")]
        public DateTime ServiceDate { get; set; }

        /// <summary>
        /// Service Cost
        /// </summary>
        [Display(Name = "Service Cost")]
        public decimal ServiceingCostDecimal { get; set; }

        /// <summary>
        /// Parts Cost
        /// </summary>
        [Display(Name = ("Parts Cost"))]
        public decimal PartsCostDecimal { get; set; }

        /// <summary>
        /// Tax
        /// </summary>
        [Display(Name = "Tax")]
        public decimal TaxDecimal { get; set; }

        /// <summary>
        /// Service By
        /// </summary>
        [Display(Name = ("Service By"))]
        public string ServiceBy { get; set; }
    }
}
