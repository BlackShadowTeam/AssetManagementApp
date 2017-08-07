using System;
using System.Collections.Generic;
using AssetModelsLibrary.AssetSetup;
using HumanResourceModelsLibrary;

namespace AssetModelsLibrary.AssetOpetation
{
    public class CheckOut
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime ReturnDate { get; set; }


        public int AssetLocationId { get; set; }
        public virtual AssetLocation AssetLocation { get; set; }

        public string Commants { get; set; }

        public int AssetEntrysId { get; set; }
        public virtual List<AssetEntry.AssetEntry> AssetEntries { get; set; }
        

    }
}
