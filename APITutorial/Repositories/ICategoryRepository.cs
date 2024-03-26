using APITutorial.Model;

namespace APITutorial.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    // kenapa Update dipisah?
    //  karena setiap tabel ada beberapa yg kalau harus update
    // dia ngga cuma update 1 table tapi ada yg beberapa tabel juga terupdate
    void Update(Category category);
}
