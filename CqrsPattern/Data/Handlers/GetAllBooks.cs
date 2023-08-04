using CqrsPattern.Models;
using CqrsPattern.Repository;
using CqrsPattern.Service;
using MediatR;

namespace CqrsPattern.Data.Handlers
{
    public class GetAllBooks : IRequestHandler<GetAllBooksQuery, List<Book>>
    {
        private readonly IBookRepository _bookRepository;

        public GetAllBooks(IBookRepository bookRepository)
        {
                _bookRepository = bookRepository;
        }
        public async Task<List<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetBooksAsync();
        }
    }
}
