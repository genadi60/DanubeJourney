namespace DanubeJourney.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Models;

    public class ShipsSeeder : ISeeder
    {
        public async Task SeedAsync(DanubeJourneyDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Ships.Any())
            {
                return;
            }

            var ships = new Dictionary<string, string>
            {
                ["Passion"] = "https://images.cruisecritic.com/image/2109/image_1000x500_21.webp",
                ["Impression"] = "https://images.cruisecritic.com/image/2103/image_1000x500_21.webp",
            };

            foreach (var kvp in ships)
            {
                var name = kvp.Key;
                var img = kvp.Value;

                await dbContext.AddAsync(new Ship
                {
                    Name = name,
                    ImageUrl = img,
                    Description = "Vivamus ultricies ex in faucibus fermentum. Vivamus a neque interdum, porta dolor vitae, dignissim velit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi est mauris, imperdiet eget ante in, tincidunt commodo nisl. Mauris lacinia bibendum lacus, ac ultricies justo mattis bibendum. Cras finibus eros vitae urna ullamcorper, nec lacinia elit placerat. Ut tristique ornare enim ac convallis.",
                    Passengers = 166,
                    Crew = 47,
                    Length = 443,
                    Staterooms = 16,
                    Suites = 67,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
