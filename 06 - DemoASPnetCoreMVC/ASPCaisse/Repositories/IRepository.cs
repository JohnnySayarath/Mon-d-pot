using System.Linq.Expressions;

namespace TPASPCaisse.Repositories
{
    public interface IRepository<TEntity> // s'adapte à plusieurs entités
    {
        bool Add(TEntity entity);
        bool Delete(int entityId);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int entityId);
        bool Update(TEntity entity);
    }
}
