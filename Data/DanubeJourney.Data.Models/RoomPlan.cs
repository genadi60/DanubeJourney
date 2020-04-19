namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class RoomPlan : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string RoomPlanUrl { get; set; }
    }
}
