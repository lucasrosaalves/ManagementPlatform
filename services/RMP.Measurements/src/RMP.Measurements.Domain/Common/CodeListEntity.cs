namespace RMP.Measurements.Domain.Common
{
    public abstract class CodeListEntity : Entity, ICodeListEntity
    {
        public string ShortString { get; set; }
        public string LongString { get; set; }
        public string Description { get; set; }
    }
}
