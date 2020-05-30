namespace DanubeJourney.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class ShipGallery : BaseDeletableModel<string>
    {
        public ShipGallery()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<ShipImage>();
        }

        public ICollection<ShipImage> Images { get; set; }
    }
}
