namespace DanubeJourney.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DanubeJourney.Data.Common.Models;

    public class EmployeesSeeder : ISeeder
    {
        public async Task SeedAsync(DanubeJourneyDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Employees.Any())
            {
                return;
            }

            var employees = new List<string>
            {
                "Ivan Georgiev", "Petar Petrov", "Georgi Ivanov", "Maya Manolova", "Korneliya Ninova", "Simeon Hristov",
            };

            foreach (var employee in employees)
            {
                var fullName = employee;
                var firstName = fullName.Split(" ")[0];
                var lastName = fullName.Split(" ")[1];

                var salary = (decimal)new Random().Next(2000, 5000);
                var experience = new Random().Next(5, 15);

                await dbContext.AddAsync(new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Salary = salary,
                    Experience = experience,
                });
            }
        }
    }
}
