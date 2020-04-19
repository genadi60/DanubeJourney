namespace DanubeJourney.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Models;

    public class EmployeesSeeder : ISeeder
    {
        public async Task SeedAsync(DanubeJourneyDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Employees.Any())
            {
                return;
            }

            var employees = new Dictionary<string, string>
            {
                ["Ivan Georgiev"] = "https://randomuser.me/api/portraits/men/91.jpg",
                ["Petar Petrov"] = "https://robohash.org/officiavoluptatemeum.png?size=125x125&set=set1",
                ["Georgi Ivanov"] = "https://robohash.org/placeatsitin.png?size=125x125&set=set1",
                ["Maya Manolova"] = "https://robohash.org/etquodquo.png?size=125x125&set=set1",
                ["Korneliya Ninova"] = "https://robohash.org/doloresfugavoluptate.png?size=125x125&set=set1",
                ["Simeon Hristov"] = "https://robohash.org/etquodquo.png?size=125x125&set=set1",
            };

            foreach (var employee in employees)
            {
                var fullName = employee.Key;
                var firstName = fullName.Split(" ")[0];
                var lastName = fullName.Split(" ")[1];
                var avatar = employee.Value;
                var salary = (decimal)new Random().Next(2000, 5000);
                var experience = new Random().Next(5, 15);

                await dbContext.AddAsync(new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Salary = salary,
                    Experience = experience,
                    Avatar = avatar,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
