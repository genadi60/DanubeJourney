namespace DanubeJourney.Data.Models
{
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class RoomCategory : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string ShipId { get; set; }

        public Ship Ship { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
