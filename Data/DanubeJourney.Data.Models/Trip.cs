namespace DanubeJourney.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class Trip : BaseDeletableModel<string>
    {
        public Trip()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string ShipId { get; set; }

        public virtual Ship Ship { get; set; }

        public string MapUrl { get; set; }

        public string GalleryId { get; set; }

        public virtual TripGallery Gallery { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
