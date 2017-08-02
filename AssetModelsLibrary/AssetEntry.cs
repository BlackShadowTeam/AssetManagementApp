using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizationModelsLibrary;

namespace AssetModelsLibrary
{
    /// <summary>
    /// Asset Entry/ Registration
    /// </summary>
    class AssetEntry
    {
        public int Id { get; set; }

        //public string AssetId { get; set; }

        [Required]
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        [Required]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        [Required]
        [Display(Name = "Asset Location")]
        public int AssetLocationId { get; set; }
        public AssetLocation AssetLocation { get; set; }

        [Required]
        [Display(Name = "Asset Type")]
        public int AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }

        [Required]
        [Display(Name = "Asset Group")]
        public int AssetGroupId { get; set; }
        public AssetGroup AssetGroup { get; set; }

        [Required]
        [Display(Name = "Manufacture")]
        public int AssetManufacturerId { get; set; }
        public AssetManufacturer AssetManufacturer { get; set; }

        [Required]
        [Display(Name = "Asset Model")]
        public int AssetModelId { get; set; }
        public AssetModel AssetModel { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Serial No")]
        public int SerialNo { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        public byte[] Attachment { get; set; }

    }
}
