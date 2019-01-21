
namespace LSC.Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        void SaveChanges();
    }
}
