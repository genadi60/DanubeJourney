namespace DanubeJourney.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ShipsController : BaseController
    {
        public IActionResult Create()
        {
            return this.View();
        }

        public IActionResult Details()
        {
            return null;
        }
    }
}
