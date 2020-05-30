namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class TripImage : BaseDeletableModel<int>
    {
        public TripImageCategory Category { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string GalleryId { get; set; }

        public TripGallery Gallery { get; set; }
    }
}
