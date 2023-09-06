using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TPASPCaisse.Data;
using TPASPCaisse.Models;

namespace TPASPCaisse.Repositories;

public class ProductRepository : IRepository<Product>
{
    private readonly ApplicationDbContext _dbContext;
    public ProductRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public bool Add(Product entity)
    {
        _dbContext.Products.Add(entity);
        _dbContext.SaveChanges();
        return true;
    }

    public bool Delete(int entityId)
    {
        var productToDelete = _dbContext.Products.Find(entityId);
        _dbContext.Products.Remove(productToDelete);
        _dbContext.SaveChanges();
        return true;
    }

    public Product? Get(Expression<Func<Product, bool>> predicate)
    {
        return _dbContext.Products.FirstOrDefault(predicate);
    }

    public List<Product> GetAll()
    {
        return _dbContext.Products.ToList();
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> predicate)
    {
        return _dbContext.Products.Where(predicate).ToList();
    }

    public Product? GetById(int entityId)
    {
        return _dbContext.Products.Find(entityId);
    }

    public bool Update(Product product)
    {
        _dbContext.Update(product);
        _dbContext.SaveChanges();
        return true;
    }
}
