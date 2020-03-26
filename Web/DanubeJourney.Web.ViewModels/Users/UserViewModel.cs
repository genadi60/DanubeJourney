namespace DanubeJourney.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class UserViewModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public virtual ICollection<BookingCard> Cards { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
