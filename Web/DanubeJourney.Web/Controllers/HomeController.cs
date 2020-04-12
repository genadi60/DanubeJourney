using DanubeJourney.Services.Data.Contracts;

namespace DanubeJourney.Web.Controllers
{
    using System.Diagnostics;

    using DanubeJourney.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ITripsService _tripsService;

        public HomeController(ITripsService tripsService)
        {
            
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
