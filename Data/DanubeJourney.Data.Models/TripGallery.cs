namespace DanubeJourney.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class TripGallery : BaseDeletableModel<string>
    {
        public TripGallery()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<TripImage>();
        }

        public ICollection<TripImage> Images { get; set; }
    }
}
