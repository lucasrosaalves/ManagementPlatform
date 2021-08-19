using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class Asset : Entity
    {
        public string Name { get; set; }
        public bool Master { get; set; }

        public Guid AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }
    }
}
