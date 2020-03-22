using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanubeJourney.Web.Controllers
{
    public class TripsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
