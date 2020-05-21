namespace DanubeJourney.Data.Models
{
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class Room : BaseDeletableModel<int>
    {
        public Room()
        {
            this.Features = new HashSet<Feature>();
        }

        public RoomCategory Category { get; set; }

        public decimal Price { get; set; }

        public int PlanId { get; set; }

        public RoomPlan Plan { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }

        public ICollection<Feature> Features { get; set; }
    }
}
