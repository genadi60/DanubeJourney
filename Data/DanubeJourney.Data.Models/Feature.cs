namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class Feature : BaseDeletableModel<int>
    {
        public string Description { get; set; }
    }
}
