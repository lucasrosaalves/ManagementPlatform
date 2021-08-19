using RMP.Measurements.Domain.Common;
using System;

namespace RMP.Measurements.Domain.CodeList
{
    public class Uom : CodeListEntity
    {
        public Guid UomTypeId { get; set; }
        public UomType UomType { get; set; }

        public Guid UomClassificationId { get; set; }
        public UomClassification UomClassification { get; set; }

    }
}
