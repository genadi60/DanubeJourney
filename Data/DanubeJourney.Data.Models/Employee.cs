namespace DanubeJourney.Data.Models
{
    using System;
    using DanubeJourney.Data.Common.Models;

    public class Employee : BaseDeletableModel<string>
    {
        public Employee()
        {
                this.Id = Guid.NewGuid().ToString();
        }

        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBird { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }
    }
}
