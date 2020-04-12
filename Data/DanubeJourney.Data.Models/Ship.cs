namespace DanubeJourney.Data.Common.Models
{
    using System;
    using System.Collections.Generic;

    public class Ship : BaseDeletableModel<string>
    {
        public Ship()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Gallery = new HashSet<Image>();
            this.Comments = new HashSet<Comment>();
            this.Facilities = new HashSet<Facility>();
            this.DeckPlans = new HashSet<Deck>();
            this.Staff = new HashSet<Employee>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Launched { get; set; }

        public int Passengers { get; set; }

        public int Crew { get; set; }

        public int Length { get; set; }

        public int Staterooms { get; set; }

        public int Suites { get; set; }

        public string CaptainId { get; set; }

        public virtual Employee Captain { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Image> Gallery { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }

        public virtual ICollection<Deck> DeckPlans { get; set; }

        public virtual ICollection<Employee> Staff { get; set; }
    }
}
