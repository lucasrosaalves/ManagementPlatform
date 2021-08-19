using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class MeasurementCategoryType : Entity
    {
        public Guid AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }

        public Guid MeasurementTypeId { get; set; }
        public MeasurementType MeasurementType { get; set; }

        public Guid MeasurementCategoryId { get; set; }
        public MeasurementCategory MeasurementCategory { get; set; }

        public Guid UomTypeId { get; set; }
        public UomType UomType { get; set; }

        public string Description { get; set; }
        public bool Required { get; set; }
    }
}
