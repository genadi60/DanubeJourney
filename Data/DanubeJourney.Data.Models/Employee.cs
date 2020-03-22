using System;
using System.Collections.Generic;
using System.Text;

namespace DanubeJourney.Data.Common.Models
{
    public class Employee : BaseDeletableModel<string>
    {
        public Employee()
        {
                this.Id = Guid.NewGuid().ToString();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBird { get; set; }

        public string Оccupation { get; set; }

        public int Experience { get; set; }

        public Decimal Salary { get; set; }
    }
}
