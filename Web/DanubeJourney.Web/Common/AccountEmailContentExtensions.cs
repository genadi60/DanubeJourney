namespace DanubeJourney.Web.Common
{
    using System.Text.Encodings.Web;

    using HtmlAgilityPack;

    public static class AccountEmailContentExtensions
    {
        public static string GetConfirmationEmailContent(this string callbackUrl)
        {
            var confirmationButton =
                $@"<a href=""{HtmlEncoder.Default.Encode(callbackUrl)}"" target=""_blank"" style=""display: inline-block; padding: 16px 36px; font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif; font-size: 16px; color: #ffffff; text-decoration: none; border-radius: 6px;"">Confirm email</a>";

            var confirmationLink =
                $@"<p style=""margin: 0;""><a href=""{HtmlEncoder.Default.Encode(callbackUrl)}"" target=""_blank"">{HtmlEncoder.Default.Encode(callbackUrl)}</a></p>";

            var emailConfirmationHtmlPath = "Views/Emails/email-confirmation.html";

            var doc = new HtmlDocument();
            doc.Load(emailConfirmationHtmlPath);

            var content = doc.Text;
            content = content
                .Replace("@confirmationButton", confirmationButton)
                .Replace("@confirmationLink", confirmationLink);
            return content;
        }
        //"trip@danube.journey.com",
        //                "admin",
        //                this.Input.Email,
        //                "Confirm your email",
        //                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

    }
}
