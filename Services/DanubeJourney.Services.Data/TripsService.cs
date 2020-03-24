using System.Linq;
using DanubeJourney.Services.Mapping;
using DanubeJourney.Web.ViewModels.Trips;

namespace DanubeJourney.Services.Data
{
    using System.Threading.Tasks;

    using DanubeJourney.Data.Common.Models;
    using DanubeJourney.Data.Common.Repositories;
    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.InputModels.Trips;

    public class TripsService : ITripsService
    {
        private readonly IRepository<Trip> _tripRepository;

        public TripsService(IRepository<Trip> tripRepository)
        {
            this._tripRepository = tripRepository;
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
            var tripViewModels =  this._tripRepository.All().Select(tr => new TripViewModel()
            {
                Id = tr.Id,
                Name = tr.Name,
                Description = tr.Description,
                Duration = tr.Duration,
                MapUrl = tr.MapUrl,
            });
            return tripViewModels.SingleOrDefault(vm => vm.Id.Equals(id));
        }
    }
}
