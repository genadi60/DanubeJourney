using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DanubeJourney.Web.InputModels.Employees;
using DanubeJourney.Web.InputModels.Rooms;
using DanubeJourney.Web.ViewModels.Employees;
using DanubeJourney.Web.ViewModels.Rooms;

namespace DanubeJourney.Services.Data.Contracts
{
    public interface IRoomsService
    {
        Task<int> Create(RoomInputModel model);

        Task<int> Details(string id);

        Task<int> Edit(RoomViewModel model);

        Task<int> Delete(string id);
    }
}
