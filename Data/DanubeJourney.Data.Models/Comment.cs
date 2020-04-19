namespace DanubeJourney.Data.Models
{
    using DanubeJourney.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

        public virtual DanubeJourneyUser Author { get; set; }
    }
}
