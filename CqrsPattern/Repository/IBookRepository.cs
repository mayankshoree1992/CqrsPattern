using CqrsPattern.Models;

namespace CqrsPattern.Repository
{
    public interface IBookRepository
    {
        public Task<Book> GetBookByIdAsync(int id);
        public Task<List<Book>> GetBooksAsync();
    }
}
