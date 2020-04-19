namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class Deck : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string DeckPlan { get; set; }
    }
}
