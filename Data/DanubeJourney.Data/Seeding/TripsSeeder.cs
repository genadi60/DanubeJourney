namespace DanubeJourney.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Models;

    public class TripsSeeder : ISeeder
    {
        public async Task SeedAsync(DanubeJourneyDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Trips.Any())
            {
                return;
            }

            var trips = new Dictionary<string, string>
            {
                ["TheBlackSea"] = "https://images.globusfamily.com/Maps/AVALON/2020/WOBB.jpg",
                ["VienneseWaltz"] = "https://images.globusfamily.com/Maps/AVALON/2020/WOBB.jpg",
                ["Symphony"] = "https://images.globusfamily.com/Maps/AVALON/2020/WOBB.jpg",
                ["Serenade"] = "https://images.globusfamily.com/Maps/AVALON/2020/WOBB.jpg",
            };

            foreach (var kvp in trips)
            {
                var name = kvp.Key;
                var img = kvp.Value;

                await dbContext.AddAsync(new Trip
                {
                    Name = name,
                    MapUrl = img,
                    Description = "River Cruise Ruse to Budapest",
                    Duration = 12,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
