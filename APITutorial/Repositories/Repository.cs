using System.Linq.Expressions;
using APITutorial.Data;
using Microsoft.EntityFrameworkCore;

namespace APITutorial.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private DataContext _db;
    private DbSet<T> _dbSet;

    public Repository(DataContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>(); //same as: _db.Category, _db.Product, _db.Employee, etc.
    }
    
    public bool Add(T entity)
    {
        _dbSet.Add(entity);
        return true;
    }

    public bool AddRange(IEnumerable<T> entities)
    {
        _db.AddRange(entities);
        return true;
    }

    public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet;
    }

    public bool Remove(T entity)
    {
        _dbSet.Remove(entity);
        return true;
    }

    public bool RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
        return true;
    }

    public async Task<int> Save()  //semuanya harusnya pakai task async await
    {
        return await _db.SaveChangesAsync();
    }

}
