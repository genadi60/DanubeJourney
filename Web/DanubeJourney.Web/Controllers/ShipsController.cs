using System.Net.Http;
using DanubeJourney.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Web.InputModels.Ships;
    using DanubeJourney.Web.ViewModels.Ships;
    using Microsoft.AspNetCore.Mvc;

    public class ShipsController : BaseController
    {
        private readonly IShipsService _shipsService;

        public ShipsController(IShipsService shipsService)
        {
            this._shipsService = shipsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var collection = this._shipsService.GetModel<ShipViewModel>();
            var model = new ShipsIndexViewModel {
                Collection = collection,
            };
            return this.View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ShipInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = this._shipsService.Create(model);
            if (result.Result == 1)
            {
                return this.View("CreatedSuccessfully");
            }

            return this.RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public IActionResult Details([FromForm]string id)
        {
            var model = this._shipsService.Details(id);
            return this.View(model);
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
