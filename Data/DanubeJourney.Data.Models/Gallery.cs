namespace DanubeJourney.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class Gallery : BaseDeletableModel<string>
    {
        public Gallery()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Categories = new HashSet<ImageCategory>();
        }

        public string Name { get; set; }

        public ICollection<ImageCategory> Categories { get; set; }
    }
}
