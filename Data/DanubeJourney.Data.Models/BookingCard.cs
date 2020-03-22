namespace DanubeJourney.Data.Common.Models
{
    using System;

    using DanubeJourney.Data.Models;

    public class BookingCard : BaseDeletableModel<string>
    {
        public BookingCard()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string TripId { get; set; }

        public virtual Trip Trip { get; set; }

        public int RoomId { get; set; }

        public virtual Room Room { get; set; }

        public Decimal Amount { get; set; }

        public string UserId { get; set; }

        public virtual DanubeJourneyUser User { get; set; }
    }
}
