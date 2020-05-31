namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class ShipImage : BaseDeletableModel<int>
    {
        public ShipImageCategory Category { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string GalleryId { get; set; }

        public virtual ShipGallery Gallery { get; set; }
    }
}
