using System.Threading.Tasks;
using DanubeJourney.Web.InputModels.Ships;
using DanubeJourney.Web.ViewModels.Ships;

namespace DanubeJourney.Services.Data.Contracts
{
    public interface IShipsService
    {
        Task<int> Create(ShipInputModel model);

        Task<int> Details(string id);

        Task<int> Edit(ShipViewModel model);

        Task<int> Delete(string id);
    }
}
