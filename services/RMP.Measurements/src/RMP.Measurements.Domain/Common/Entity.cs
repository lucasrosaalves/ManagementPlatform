using System;

namespace RMP.Measurements.Domain.Common
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public Guid TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
