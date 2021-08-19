namespace RMP.Measurements.Domain.Common
{
    public interface ICodeListEntity : IEntity
    {
        public string ShortString { get; set; }
        public string LongString { get; set; }
        public string Description { get; set; }
    }
}
