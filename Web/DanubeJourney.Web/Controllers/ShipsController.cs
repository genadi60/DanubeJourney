namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Web.InputModels.Ships;
    using DanubeJourney.Web.ViewModels.Ships;
    using Microsoft.AspNetCore.Mvc;

    public class ShipsController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ShipInputModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Details(ShipViewModel model)
        {
            return null;
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Edit(ShipViewModel model)
        {
            return null;
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Delete(ShipViewModel model)
        {
            return null;
        }
    }
}
