using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {

        }
    }
}
