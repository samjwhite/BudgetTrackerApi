﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BudgetTracker.Core.Modules;

namespace BudgetTracker.Models
{
    public class RecordPlaceOfPurchaseCategory : ModelBase
    {
        [Required]
        [ForeignKey("Record")]
        public Guid RecordId { get; set; }
        public Record Record { get; set; }

        [Required]
        [ForeignKey("PlaceOfPurchase")]
        public Guid PlaceOfPurchaseId { get; set; }
        public virtual PlaceOfPurchase PlaceOfPurchase { get; set; }

        [Required]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
