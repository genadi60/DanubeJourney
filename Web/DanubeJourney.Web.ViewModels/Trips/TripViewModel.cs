namespace DanubeJourney.Web.ViewModels.Trips
{
    using DanubeJourney.Data.Common.Models;
    using DanubeJourney.Data.Models;
    using DanubeJourney.Services.Mapping;

    public class TripViewModel : IMapFrom<Trip>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string ShipId { get; set; }

        public Ship Ship { get; set; }

        public string MapUrl { get; set; }
    }
}
