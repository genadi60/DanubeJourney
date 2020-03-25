namespace DanubeJourney.Web.ViewModels.Ships
{
    using DanubeJourney.Data.Common.Models;

    public class ShipViewModel
    {
        public string Name { get; set; }

        public int Launched { get; set; }

        public int Passengers { get; set; }

        public int Crew { get; set; }

        public int Length { get; set; }

        public int Staterooms { get; set; }

        public int Suites { get; set; }

        public string CaptainId { get; set; }

        public virtual Employee Captain { get; set; }
    }
}
