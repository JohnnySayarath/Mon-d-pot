using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TPASPCaisse.Data;
using TPASPCaisse.Models;

namespace TPASPCaisse.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Category entity)
        {
            _dbContext.Categories.Add(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(int entityId)
        {
            var categoryToDelete = GetById(entityId);
            if (categoryToDelete == null)
                return false;
            _dbContext.Categories.Remove(categoryToDelete);
            return _dbContext.SaveChanges() > 0;
        }

        public Category? Get(Expression<Func<Category, bool>> predicate)
        {
            return _dbContext.Categories.Include(c => c.Products).FirstOrDefault(predicate);
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> predicate)
        {
            return _dbContext.Categories.Where(predicate).ToList();
        }

        public Category? GetById(int entityId)
        {
            return _dbContext.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == entityId);
        }

        public bool Update(Category entity)
        {
            var categorieFromDb = GetById(entity.Id);
            if (categorieFromDb == null)
                return false;
            if (categorieFromDb.Name != entity.Name)
                categorieFromDb.Name = entity.Name;
            return _dbContext.SaveChanges() > 0;
        }
    }
}
