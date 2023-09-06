using Exo4Marmoset.Data;
using Exo4Marmoset.Models;
using System.Linq.Expressions;

namespace Exo4Marmoset.Repositories
{
    public class MarmosetRepository : IMarmosetRepository
    {
        private ApplicationDbContext _dbContext;
        public MarmosetRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CREATE
        public bool Add(Marmoset marmoset)
        {
            var addedObj = _dbContext.Marmosets.Add(marmoset);
            _dbContext.SaveChanges();
            return addedObj.Entity.Id > 0;
        }

        // READ
        public Marmoset? GetById(int id)
        {
            return _dbContext.Marmosets.Find(id);
        }
        public Marmoset? Get(Expression<Func<Marmoset, bool>> predicate)
        {
            return _dbContext.Marmosets.FirstOrDefault(predicate);
        }
        public List<Marmoset> GetAll()
        {
            return _dbContext.Marmosets.ToList();
        }
        public List<Marmoset> GetAll(Expression<Func<Marmoset, bool>> predicate)
        {
            return _dbContext.Marmosets.Where(predicate).ToList();
        }

        // UPDATE
        public bool Update(Marmoset marmoset)
        {
            var marmosetFromDb = GetById(marmoset.Id);

            if (marmosetFromDb == null)
                return false;

            if (marmosetFromDb.Name != marmoset.Name)
                marmosetFromDb.Name = marmoset.Name;
            if (marmosetFromDb.Age != marmoset.Age)
                marmosetFromDb.Age = marmoset.Age;

            return _dbContext.SaveChanges() > 0;
        }

        // DELETE
        public bool Delete(int id)
        {
            var marmoset = GetById(id);
            if (marmoset == null)
                return false;
            _dbContext.Marmosets.Remove(marmoset);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
