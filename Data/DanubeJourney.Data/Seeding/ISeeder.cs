namespace DanubeJourney.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(DanubeJourneyDbContext dbContext, IServiceProvider serviceProvider);
    }
}
