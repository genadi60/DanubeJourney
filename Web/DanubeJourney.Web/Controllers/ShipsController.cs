using Microsoft.AspNetCore.Routing;

namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Services.Data.Contracts;
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
            var collection = this._shipsService.GetModels<ShipViewModel>();
            var model = new ShipsIndexViewModel
            {
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

        [HttpGet]
        public IActionResult Details([FromRoute]string id)
        {
            var model = this._shipsService.Details(id);
            return this.View(model);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var model = this._shipsService.GetModel<ShipViewModel>(id);
            return this.View(model);
        }

        [HttpPost]
        public IActionResult Edit(ShipViewModel model)
        {
            var id = this._shipsService.Edit(model);
            return this.RedirectToAction("Details", new RouteValueDictionary(new { controller = "Ships", action = "Details", id = id.Result }));
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
