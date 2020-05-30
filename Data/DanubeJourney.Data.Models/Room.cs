namespace DanubeJourney.Data.Models
{
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class Room : BaseDeletableModel<int>
    {
        public RoomType Type { get; set; }

        public RoomCategory Category { get; set; }

        public decimal Price { get; set; }

        public int Area { get; set; }

        public string PlanUrl { get; set; }

        public string ImageUrl { get; set; }

        public string ShipId { get; set; }

        public virtual Ship Ship { get; set; }

        public string Features { get; set; }
    }
}
