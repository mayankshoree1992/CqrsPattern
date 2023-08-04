using CqrsPattern.Data;
using CqrsPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CqrsPattern.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly EF_DataContext _dbContext;
        public BookRepository(EF_DataContext dbContext)
        { 
            _dbContext = dbContext;
        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            var entity =  await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            var entity = await _dbContext.Books.ToListAsync();
            return entity;
        }
    }
}
