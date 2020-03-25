namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Web.InputModels.Employees;
    using DanubeJourney.Web.ViewModels.Employees;
    using Microsoft.AspNetCore.Mvc;

    public class EmployeesController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeInputModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Details(EmployeeViewModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Delete(EmployeeViewModel model)
        {
            return this.View();
        }
    }
}
