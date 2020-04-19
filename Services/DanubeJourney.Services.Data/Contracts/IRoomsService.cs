namespace DanubeJourney.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using DanubeJourney.Web.InputModels.Rooms;
    using DanubeJourney.Web.ViewModels.Rooms;

    public interface IRoomsService
    {
        Task<int> Create(RoomInputModel model);

        Task<int> Details(string id);

        Task<int> Edit(RoomViewModel model);

        Task<int> Delete(string id);
    }
}
