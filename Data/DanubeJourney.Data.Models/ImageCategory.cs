namespace DanubeJourney.Data.Models
{
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class ImageCategory : BaseDeletableModel<int>
    {
        public ImageCategory()
        {
            this.Collection = new HashSet<Image>();
        }

        public string Name { get; set; }

        public ICollection<Image> Collection { get; set; }
    }
}
