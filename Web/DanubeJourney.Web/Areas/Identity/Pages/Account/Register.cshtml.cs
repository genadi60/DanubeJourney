using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

using DanubeJourney.Data.Common.Repositories;
using DanubeJourney.Data.Models;
using DanubeJourney.Data.Repositories;
using DanubeJourney.Services.Messaging;
using DanubeJourney.Web.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using IEmailSender = DanubeJourney.Services.Messaging.IEmailSender;

namespace DanubeJourney.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<DanubeJourneyUser> _signInManager;
        private readonly UserManager<DanubeJourneyUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<DanubeJourneyRole> _roleManager;
        private readonly IRepository<IdentityUserRole<string>> _userRoleRepository;

        public RegisterModel(
            UserManager<DanubeJourneyUser> userManager,
            SignInManager<DanubeJourneyUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<DanubeJourneyRole> roleManager,
            IRepository<IdentityUserRole<string>> userRoleRepository)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._logger = logger;
            this._emailSender = emailSender;
            this._roleManager = roleManager;
            this._userRoleRepository = userRoleRepository;
        }

        [BindProperty]
        public RegisterInputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class RegisterInputModel
        {
            [Required]
            [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            this.ReturnUrl = returnUrl;
            this.ExternalLogins = (await this._signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? this.Url.Content("~/");
            this.ExternalLogins = (await this._signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (this.ModelState.IsValid)
            {
                var user = new DanubeJourneyUser
                {
                    UserName = this.Input.Username,
                    Email = this.Input.Email,
                };
                var roleName = this._userManager.Users.Any() ? "User" : "Administrator";
                user.Role = this._roleManager.Roles.FirstOrDefault(r => r.Name == roleName);

                // For validating unique email
                IdentityResult result = null;
                IdentityError[] customErrors = null;
                try
                {
                    result = await this._userManager.CreateAsync(user, this.Input.Password);
                }
                catch (DbUpdateException ex)
                {
                    result = new IdentityResult();

                    if (ex.InnerException.Message.Contains("IX_AspNetUsers_Email"))
                    {
                        var exceptionMessage = $"User with email {user.Email} already exists.";
                        customErrors = new[]
                        {
                            new IdentityError { Code = string.Empty, Description = exceptionMessage },
                        };
                    }
                }

                if (result.Succeeded)
                {
                    this._logger.LogInformation("User created a new account with password.");
                    var userRole = new IdentityUserRole<string>
                    {
                        RoleId = user.Role?.Id,
                        UserId = user.Id,
                    };
                    user.Roles.Add(userRole);
                    await this._userRoleRepository.AddAsync(userRole);
                    await this._userRoleRepository.SaveChangesAsync();
                    var code = await this._userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = this.Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: this.Request.Scheme);
                    var emailContent = callbackUrl.GetConfirmationEmailContent();
                    await this._emailSender.SendEmailAsync(
                        "trip@danube.journey.com",
                        "admin",
                        this.Input.Email,
                        "Confirm your email",
                        emailContent);

                    // $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>."
                    if (this._userManager.Options.SignIn.RequireConfirmedEmail)
                    {
                        return this.LocalRedirect("~/Emails/Confirm");
                    }
                    else
                    {
                        await this._signInManager.SignInAsync(user, isPersistent: false);
                        return this.LocalRedirect(returnUrl);
                    }
                }

                foreach (var error in result.Errors)
                {
                    this.ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return this.Page();
        }
    }
}
