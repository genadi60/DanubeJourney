namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class Facility : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
