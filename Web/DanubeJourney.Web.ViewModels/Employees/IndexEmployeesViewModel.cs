using System;
using System.Collections.Generic;
using System.Text;

namespace DanubeJourney.Web.ViewModels.Employees
{
    public class IndexEmployeesViewModel
    {
        public IndexEmployeesViewModel()
        {
            this.Collection = new List<EmployeeViewModel>();
        }

        public ICollection<EmployeeViewModel> Collection { get; set; }
    }
}
