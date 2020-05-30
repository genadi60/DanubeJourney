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
            this.Rooms = new HashSet<Room>();
            this.Comments = new HashSet<Comment>();
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

        public string DeckPlansUrl { get; set; }

        public string Amenities { get; set; }

        public string Dining { get; set; }

        public string GalleryId { get; set; }

        public virtual ShipGallery Gallery { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Employee> Staff { get; set; }
    }
}
