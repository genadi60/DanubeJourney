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
            };

            await this._repository.AddAsync(ship);
            return await this._repository.SaveChangesAsync();
        }

        public ShipViewModel Details(string id)
        {
            return this._repository.All().To<ShipViewModel>().FirstOrDefault(vm => vm.Id.Equals(id));
        }

        public Task<int> Edit(ShipViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetModel<T>()
        {
            return this._repository.All().To<T>().ToList();
        }
    }
}
