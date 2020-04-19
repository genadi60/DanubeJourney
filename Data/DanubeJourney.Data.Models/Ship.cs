namespace DanubeJourney.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DanubeJourney.Data.Common.Models;

    public class Ship : BaseDeletableModel<string>
    {
        public Ship()
        {
            this.Id = Guid.NewGuid().ToString();
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

        public Employee Captain { get; set; }

        public string ImageUrl { get; set; }

        public string GalleryId { get; set; }

        public Gallery Gallery { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Facility> Facilities { get; set; }

        public ICollection<Deck> DeckPlans { get; set; }

        public ICollection<Employee> Staff { get; set; }
    }
}
