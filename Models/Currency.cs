using System.ComponentModel.DataAnnotations;
using BudgetTracker.Core.Modules;

namespace BudgetTracker.Models
{
    public class Currency : ModelBase
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Symbol { get; set; }
    }
}