using AssetModelsLibrary.AssetSetup;
using HumanResourceModelsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetOpetation
{
    public class CheckOut
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [Display(Name = "Entry Date")]
        public DateTime EntryDate { get; set; }

        [Required]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Asset Location")]
        public int AssetLocationId { get; set; }
        public virtual AssetLocation AssetLocation { get; set; }

        public string Commants { get; set; }

        [Display(Name = "Asset")]
        public int AssetEntrysId { get; set; }
        public virtual IEnumerable<AssetEntrys.AssetEntry> AssetEntries { get; set; }


    }
}
