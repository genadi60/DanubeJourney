

namespace DanubeJourney.Web.InputModels.Trips
{
    using DanubeJourney.Services.Mapping;
    using DanubeJourney.Data.Common.Models;

    public class TripInputModel : IMapTo<Trip>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

       public string Ship { get; set; }

        public string MapUrl { get; set; }
    }
}
