using System.ComponentModel.DataAnnotations;
using BudgetTracker.Core.Modules;
using Microsoft.AspNetCore.Identity;

namespace BudgetTracker.Models
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
