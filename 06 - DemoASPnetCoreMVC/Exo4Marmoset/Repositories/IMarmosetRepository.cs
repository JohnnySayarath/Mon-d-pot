using Exo4Marmoset.Models;
using System.Linq.Expressions;

namespace Exo4Marmoset.Repositories
{
    public interface IMarmosetRepository
    {
        bool Add(Marmoset marmoset);
        bool Delete(int id);
        Marmoset? Get(Expression<Func<Marmoset, bool>> predicate);
        List<Marmoset> GetAll();
        List<Marmoset> GetAll(Expression<Func<Marmoset, bool>> predicate);
        Marmoset? GetById(int id);
        bool Update(Marmoset marmoset);
    }
}