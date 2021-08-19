using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class AssetMeasurement : Entity
    {
        public DateTime Timestamp { get; set; }
        public string Value { get; set; }
        public bool ManualMeasurement { get; set; }
        public bool NewOrModified { get; set; }

        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }

        public Guid MeasurementCategoryTypeId { get; set; }
        public MeasurementCategoryType MeasurementCategoryType { get; set; }


        public Guid? UomId { get; set; }
        public Uom Uom { get; set; }

        public Guid DataTypeId { get; set; }
        public DataType DataType { get; set; }
    }
}
