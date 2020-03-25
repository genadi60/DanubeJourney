namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Web.InputModels.Rooms;
    using DanubeJourney.Web.ViewModels.Rooms;
    using Microsoft.AspNetCore.Mvc;

    public class RoomsController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(RoomInputModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Details(RoomViewModel model)
        {
            return null;
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Edit(RoomViewModel model)
        {
            return null;
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return null;
        }

        [HttpPost]
        public IActionResult Delete(RoomViewModel model)
        {
            return null;
        }
    }
}
