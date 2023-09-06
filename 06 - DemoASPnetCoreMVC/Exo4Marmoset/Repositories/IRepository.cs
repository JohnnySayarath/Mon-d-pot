using System.Linq.Expressions;

namespace Exo4Marmoset.Repositories
{
    public interface IRepository<TEntity>
    {
        bool Add(TEntity marmoset);
        bool Delete(int id);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
        bool Update(TEntity marmoset);
    }
}
