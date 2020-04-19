using DanubeJourney.Web.InputModels.Rooms;
using DanubeJourney.Web.ViewModels.Rooms;

namespace DanubeJourney.Services.Data
{
    using System;
    using System.Threading.Tasks;

    using DanubeJourney.Services.Data.Contracts;

    public class RoomsService : IRoomsService
    {
        public Task<int> Create(RoomInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(RoomViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
