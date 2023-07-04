using System.ComponentModel.DataAnnotations;
using BudgetTrackerApi.Core.Modules;

namespace BudgetTrackerApi.Models
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