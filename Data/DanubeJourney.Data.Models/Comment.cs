namespace DanubeJourney.Data.Common.Models
{
    using System;

    using DanubeJourney.Data.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public string AuthorId { get; set; }

        public virtual DanubeJourneyUser Author { get; set; }
    }
}
