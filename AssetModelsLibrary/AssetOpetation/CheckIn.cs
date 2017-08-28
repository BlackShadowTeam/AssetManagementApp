using System;

namespace AssetModelsLibrary.AssetOpetation
{
    public class CheckIn
    {
        public int Id { get; set; }

        public int CheckOutId { get; set; }
        public CheckOut CheckOut { get; set; }

        public DateTime CheckInDate { get; set; }
    }
}
