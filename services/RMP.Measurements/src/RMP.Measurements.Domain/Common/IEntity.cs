using System;

namespace RMP.Measurements.Domain.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool Deleted { get; set; }
        Guid TransactionId { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
