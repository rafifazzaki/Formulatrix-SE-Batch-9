using System.Linq.Expressions;

namespace APITutorial.Repositories;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    IEnumerable<T> Get(Expression<Func<T, bool>> expression); //for receive lambda function
    bool Add(T entity);
    bool AddRange(IEnumerable<T> entities); //for receiving many entities
    bool Remove(T entity);
    bool RemoveRange(IEnumerable<T> entities); //for receiving many entities
    Task<int> Save(); //semuanya harusnya pakai task async await
}
