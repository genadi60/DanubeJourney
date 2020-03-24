namespace DanubeJourney.Web.InputModels.Ships
{
    public class ShipInputModel
    {
        public string Name { get; set; }

        public int Launched { get; set; }

        public int Passengers { get; set; }

        public int Crew { get; set; }

        public int Length { get; set; }

        public int Staterooms { get; set; }

        public int Suites { get; set; }

        public string CaptainId { get; set; }
    }
}
