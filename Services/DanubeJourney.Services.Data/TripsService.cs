namespace DanubeJourney.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Common.Models;
    using DanubeJourney.Data.Common.Repositories;
    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Services.Mapping;
    using DanubeJourney.Web.InputModels.Trips;
    using DanubeJourney.Web.ViewModels.Trips;

    public class TripsService : ITripsService
    {
        private readonly IDeletableEntityRepository<Trip> _tripRepository;

        public TripsService(IDeletableEntityRepository<Trip> tripRepository)
        {
            this._tripRepository = tripRepository;
        }

        public IndexTripsViewModel Index()
        {
            var model = new IndexTripsViewModel
            {
                Collection = this._tripRepository.All().To<TripViewModel>().ToList(),
            };
            return model;
        }

        public string Create(TripInputModel model)
        {
            var trip = new Trip
            {
                Name = model.Name,
                Description = model.Description,
                Duration = model.Duration,
                MapUrl = model.MapUrl,
            };

            this._tripRepository.AddAsync(trip);
            this._tripRepository.SaveChangesAsync();

            return trip.Id;
        }

        public async Task<int> Edit(TripInputModel model)
        {
            var trip = new Trip();
            this._tripRepository.Update(trip);

            await this._tripRepository.SaveChangesAsync();
            return 1;
        }

        public TripViewModel Details(string id)
        {
            return this._tripRepository.All().To<TripViewModel>().SingleOrDefault(vm => vm.Id.Equals(id));
        }
    }
}
