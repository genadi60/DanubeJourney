namespace DanubeJourney.Web.ViewModels.Ships
{
    using System.Collections.Generic;

    public class ShipsIndexViewModel
    {
        public ShipsIndexViewModel()
        {
            this.Collection = new List<ShipViewModel>();
        }

        public ICollection<ShipViewModel> Collection { get; set; }
    }
}
