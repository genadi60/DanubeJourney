namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public int CategoryId { get; set; }

        public ImageCategory Category { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
