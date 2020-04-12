namespace DanubeJourney.Web.ViewModels.Trips
{
    using System.Collections.Generic;

    public class IndexTripsViewModel
    {
        public IndexTripsViewModel()
        {
            this.Collection = new List<TripViewModel>();
        }

        public ICollection<TripViewModel> Collection { get; set; }
    }
}
