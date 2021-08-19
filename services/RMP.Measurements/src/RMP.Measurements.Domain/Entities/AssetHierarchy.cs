using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class AssetHierarchy : Entity
    {
        public Guid ParentId { get; set; }
        public Asset Parent { get; set; }

        public Guid ChildId { get; set; }
        public Asset Child { get; set; }
    }
}
