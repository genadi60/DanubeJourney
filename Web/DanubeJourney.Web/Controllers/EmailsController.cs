namespace DanubeJourney.Web.Controllers
{
    using DanubeJourney.Web.InputModels.Emails;
    using Microsoft.AspNetCore.Mvc;

    public class EmailsController : BaseController
    {
        public EmailsController()
        {
        }

        public IActionResult Confirm()
        {
            var model = new EmailConfirmMessage()
            {
                Message = "Please, visit your email and confirm registration.",
            };
            return this.View(model);
        }
    }
}