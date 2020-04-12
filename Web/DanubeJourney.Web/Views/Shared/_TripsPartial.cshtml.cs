namespace DanubeJourney.Web.Views.Shared
{
    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.ViewModels.Trips;

    public class TripsPartialModel
    {
        private readonly ITripsService _tripsService;

        public TripsPartialModel(ITripsService tripsService)
        {
            this._tripsService = tripsService;
            this.Trips = this.Index();
        }

        public IndexTripsViewModel Trips { get; set; }

        public IndexTripsViewModel Index()
        {
            return this._tripsService.Index();
        }
    }
}
