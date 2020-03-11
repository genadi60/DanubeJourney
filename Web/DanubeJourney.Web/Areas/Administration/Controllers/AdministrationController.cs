namespace DanubeJourney.Web.Areas.Administration.Controllers
{
    using DanubeJourney.Common;
    using DanubeJourney.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
