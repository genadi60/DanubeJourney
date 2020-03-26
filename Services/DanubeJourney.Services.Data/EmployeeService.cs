namespace DanubeJourney.Services.Data
{
    using System;
    using System.Threading.Tasks;

    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.InputModels.Employees;
    using DanubeJourney.Web.ViewModels.Employees;

    public class EmployeeService : IEmployeesService
    {
        public Task<int> Create(EmployeeInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Edit(EmployeeViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
