using DanubeJourney.Data.Common.Models;
using DanubeJourney.Data.Common.Repositories;
using DanubeJourney.Services.Mapping;

namespace DanubeJourney.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Web.InputModels.Employees;
    using DanubeJourney.Web.ViewModels.Employees;

    public class EmployeesService : IEmployeesService
    {
        private readonly IDeletableEntityRepository<Employee> _employeeRepository;

        public EmployeesService(IDeletableEntityRepository<Employee> employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public IndexEmployeesViewModel Index()
        {
            var model = new IndexEmployeesViewModel
            {
                Collection = this._employeeRepository.All().To<EmployeeViewModel>().ToList(),
            };
            return model;
        }

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
