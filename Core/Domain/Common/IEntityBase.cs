namespace Core.Domain.Common
{
    public interface IEntityBase
    {
        bool IsDeleted { get; set; }
    }
}