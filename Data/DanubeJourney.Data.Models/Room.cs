namespace DanubeJourney.Data.Common.Models
{
    using System.Collections.Generic;

    public class Room : BaseDeletableModel<int>
    {
        public Room()
        {
            this.Features = new HashSet<Feature>();
        }

        public RoomCategory Category { get; set; }

        public decimal Price { get; set; }

        public RoomPlan Plan { get; set; }

        public Image Image { get; set; }

        public virtual ICollection<Feature> Features { get; set; }
    }
}
