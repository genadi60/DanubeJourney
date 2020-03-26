namespace DanubeJourney.Services.Data
{
    using System;
    using System.Threading.Tasks;

    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.InputModels.Ships;
    using DanubeJourney.Web.ViewModels.Ships;

    public class ShipsService : IShipsService
    {
        public Task<int> Create(ShipInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(ShipViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
