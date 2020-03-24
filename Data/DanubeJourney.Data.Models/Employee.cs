namespace DanubeJourney.Data.Common.Models
{
    using System;

    public class Employee : BaseDeletableModel<string>
    {
        public Employee()
        {
                this.Id = Guid.NewGuid().ToString();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBird { get; set; }

        public string Оccupation { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }
    }
}
