namespace DanubeJourney.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using DanubeJourney.Web.InputModels.Trips;
    using DanubeJourney.Web.ViewModels.Trips;

    public interface ITripsService
    {
        IndexTripsViewModel Index();

        string Create(TripInputModel model);

        Task<int> Edit(TripInputModel model);

        TripViewModel Details(string id);
    }
}
