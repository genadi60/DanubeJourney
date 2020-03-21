// ReSharper disable VirtualMemberCallInConstructor
namespace DanubeJourney.Data.Models
{
    using System;

    using DanubeJourney.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class DanubeJourneyRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public DanubeJourneyRole()
            : this(null)
        {
        }

        public DanubeJourneyRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
