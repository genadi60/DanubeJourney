namespace DanubeJourney.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using DanubeJourney.Web.InputModels.Employees;
    using DanubeJourney.Web.ViewModels.Employees;

    public interface IEmployeesService
    {
        IndexEmployeesViewModel Index();

        Task<int> Create(EmployeeInputModel model);

        Task<int> Details(string id);

        Task<int> Edit(EmployeeViewModel model);

        Task<int> Delete(string id);
    }
}
