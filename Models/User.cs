using BudgetTrackerApi.Core.Modules;
using Microsoft.AspNetCore.Identity;

namespace BudgetTrackerApi.Models
{
    public class User : IdentityUser<Guid>, IModelBase
    {
        public User()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
        }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
