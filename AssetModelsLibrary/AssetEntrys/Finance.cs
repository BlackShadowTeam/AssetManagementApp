using System;
using System.ComponentModel.DataAnnotations;
using OrganizationModelsLibrary;

namespace AssetModelsLibrary.AssetEntrys
{
    /// <summary>
    /// Asset Finance
    /// </summary>
    public class Finance
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Vendor Table Id
        /// Foreign Key 
        /// Required Propriety
        /// </summary>
        [Required]
        [Display(Name = "Vendor")]
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }

        /// <summary>
        /// Perchase Price
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name ="Perchase Price")]
        public decimal PerchasePriceDecimal { get; set; }

        /// <summary>
        /// Perchage Order No
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "P/O No")]
        public string PerchaseOrderNo { get; set; }

        /// <summary>
        /// Perchase Date
        /// Required Proprity
        /// </summary>
        [Required]
        [Display(Name = "Perchase Date")]
        public DateTime PurchaseDate { get; set; }
    }
}
