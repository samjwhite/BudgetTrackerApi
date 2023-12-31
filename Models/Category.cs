﻿using System.ComponentModel.DataAnnotations;
using BudgetTrackerApi.Core.Modules;

namespace BudgetTrackerApi.Models
{
    public class Category : ModelBase
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}