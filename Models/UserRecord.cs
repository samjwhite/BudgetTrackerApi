using BudgetTracker.Core.Modules;

namespace BudgetTracker.Models
{
    public class UserRecord : ModelBase
    {
        public int UserId { get; set; }
        public int RecordId { get; set; }
    }
}
