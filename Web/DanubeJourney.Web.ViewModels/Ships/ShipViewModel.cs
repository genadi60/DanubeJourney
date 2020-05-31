namespace DanubeJourney.Web.ViewModels.Ships
{

    using DanubeJourney.Data.Models;
    using DanubeJourney.Services.Mapping;
    using Ganss.XSS;

    public class ShipViewModel : IMapFrom<Ship>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Amenities { get; set; }

        public string SanitaisedAmenities => new HtmlSanitizer().Sanitize(this.Amenities);

        public string Dining { get; set; }

        public string SanitaisedDining => new HtmlSanitizer().Sanitize(this.Dining);

        //public string ShortDescription => WebUtility.HtmlDecode(Regex.Replace(this.Description.Substring(0, 300), @"<[^>]+>", string.Empty) + "...");

        //public string SanitaisedDescription => new HtmlSanitizer().Sanitize(this.Description);

        public int Launched { get; set; }

        public int Passengers { get; set; }

        public int Crew { get; set; }

        public int Length { get; set; }

        public int Staterooms { get; set; }

        public int Suites { get; set; }

        public string CaptainId { get; set; }

        public virtual Employee Captain { get; set; }

        public string ImageUrl { get; set; }

        public string DeckPlansUrl { get; set; }
    }
}
