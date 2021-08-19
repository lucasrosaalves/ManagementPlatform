using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class Template : Entity
    {
        public string Name { get; set; }

        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }

        public Guid AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }
    }
}
