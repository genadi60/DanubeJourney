namespace DanubeJourney.Web.ViewModels.Employees
{
    using System;

    public class EmployeeViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBird { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }
    }
}
