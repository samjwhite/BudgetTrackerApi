using System.ComponentModel.DataAnnotations;
using BudgetTrackerApi.Core.Modules;

namespace BudgetTrackerApi.Models
{
    public class RecordType : ModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}