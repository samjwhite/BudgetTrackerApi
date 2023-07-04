using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BudgetTrackerApi.Core.Modules;

namespace BudgetTrackerApi.Models
{
    public class Record : ModelBase
    {
        [MaxLength(100)]
        public string? Description { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        [ForeignKey("RecordType")]
        public Guid RecordTypeId { get; set; }
        public virtual RecordType RecordType { get; set; }

        [Required]
        [ForeignKey("Currency")]
        public Guid CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        [Required]
        [ForeignKey("PaymentType")]
        public Guid PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}

