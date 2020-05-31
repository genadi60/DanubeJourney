namespace DanubeJourney.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Common.Models;
    using DanubeJourney.Data.Common.Repositories;
    using DanubeJourney.Data.Models;
    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Services.Mapping;
    using DanubeJourney.Web.InputModels.Ships;
    using DanubeJourney.Web.ViewModels.Ships;

    public class ShipsService : IShipsService
    {
        private readonly IDeletableEntityRepository<Ship> _repository;

        public ShipsService(IDeletableEntityRepository<Ship> repository)
        {
            this._repository = repository;
        }

        public async Task<int> Create(ShipInputModel model)
        {
            var ship = new Ship
            {
                Name = model.Name,
                Launched = model.Launched,
                Passengers = model.Passengers,
                Length = model.Length,
                Staterooms = model.Staterooms,
                Suites = model.Suites,
                Crew = model.Crew,
                CaptainId = model.CaptainId,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
            };

            await this._repository.AddAsync(ship);
            return await this._repository.SaveChangesAsync();
        }

        public ShipViewModel Details(string id)
        {
            return this._repository.All().To<ShipViewModel>().FirstOrDefault(vm => vm.Id.Equals(id));
        }

        public async Task<string> Edit(ShipViewModel model)
        {
            var ship = this._repository.All().FirstOrDefault(sh => sh.Id == model.Id);
            ship.Name = model.Name;
            ship.Launched = model.Launched;
            ship.Passengers = model.Passengers;
            ship.Crew = model.Crew;
            ship.Length = model.Length;
            ship.Staterooms = model.Staterooms;
            ship.Suites = model.Suites;
            ship.CaptainId = model.CaptainId;
            ship.ImageUrl = model.ImageUrl;
            ship.Description = model.Description;
            ship.Amenities = model.Amenities;
            ship.Dining = model.Dining;
            ship.DeckPlansUrl = model.DeckPlansUrl;

            this._repository.Update(ship);
            await this._repository.SaveChangesAsync();
            return ship.Id;
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetModels<T>()
        {
            return this._repository.All().To<T>().ToList();
        }

        public T GetModel<T>(string id)
        {
            return this._repository.All().Where(sh => sh.Id == id).To<T>().FirstOrDefault();
        }
    }
}
