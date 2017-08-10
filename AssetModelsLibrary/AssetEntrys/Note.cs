using System.ComponentModel.DataAnnotations;

namespace AssetModelsLibrary.AssetEntrys
{
    public class Note
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
        /// Asset Notes
        /// </summary>
        public string Notes { get; set; }
    }
}
