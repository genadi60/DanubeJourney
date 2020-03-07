using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DanubeJourney.Data
{
    public class DanubeJourneyDbContext : IdentityDbContext
    {
        public DanubeJourneyDbContext(DbContextOptions<DanubeJourneyDbContext> options)
            : base(options)
        {
        }
    }
}
