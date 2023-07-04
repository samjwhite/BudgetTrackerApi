using BudgetTrackerApi.Core.Modules;

namespace BudgetTrackerApi.Models
{
    public class UserRecord : ModelBase
    {
        public int UserId { get; set; }
        public int RecordId { get; set; }
    }
}
