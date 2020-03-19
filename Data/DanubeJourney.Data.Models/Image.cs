namespace DanubeJourney.Data.Common.Models
{
    public class Image : BaseDeletableModel<int>
    {
        public ImageCategory Category { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
