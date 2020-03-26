namespace DanubeJourney.Services.Data
{
    using System;
    using System.Threading.Tasks;

    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.ViewModels.Users;

    public class UsersService : IUsersService
    {
        public Task<int> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
