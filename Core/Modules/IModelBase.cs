using System.ComponentModel.DataAnnotations;

namespace BudgetTracker.Core.Modules
{
    public interface IModelBase
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }

    public abstract class ModelBase : IModelBase
    {
        protected ModelBase()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
