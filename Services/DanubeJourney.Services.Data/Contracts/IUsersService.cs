namespace DanubeJourney.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using DanubeJourney.Web.ViewModels.Users;

    public interface IUsersService
    {
        Task<int> Details(string id);

        Task<int> Edit(UserViewModel model);

        Task<int> Delete(string id);
    }
}
