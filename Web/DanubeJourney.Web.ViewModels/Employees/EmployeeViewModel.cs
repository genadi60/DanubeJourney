namespace DanubeJourney.Web.ViewModels.Employees
{
    using System;

    using DanubeJourney.Data.Common.Models;
    using DanubeJourney.Services.Mapping;

    public class EmployeeViewModel : IMapFrom<Employee>
    {
        public string Id { get; set; }
        
        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBird { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }
    }
}
