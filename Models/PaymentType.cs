using System.ComponentModel.DataAnnotations;
using BudgetTracker.Core.Modules;

namespace BudgetTracker.Models
{
    public class PaymentType : ModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}