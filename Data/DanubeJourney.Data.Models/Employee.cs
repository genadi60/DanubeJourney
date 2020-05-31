namespace DanubeJourney.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        public DateTime? DateOfBird { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }
    }
}
