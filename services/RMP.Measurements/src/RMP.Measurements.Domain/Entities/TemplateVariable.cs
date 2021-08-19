using RMP.Measurements.Domain.CodeList;
using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.Entities
{
    public class TemplateVariable : Entity
    {
        public Guid TemplateId { get; set; }
        public Template Template { get; set; }

        public Guid MeasurementCategoryTypeId { get; set; }
        public MeasurementCategoryType MeasurementCategoryType { get; set; }

        public Guid UomId { get; set; }
        public Uom Uom { get; set; }

        public Guid DataTypeId { get; set; }
        public DataType DataType { get; set; }

        public bool Editable { get; set; }
        public bool Required { get; set; }

    }
}
