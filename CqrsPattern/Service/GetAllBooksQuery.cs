using CqrsPattern.Models;
using MediatR;

namespace CqrsPattern.Service
{
    public class GetAllBooksQuery : IRequest<List<Book>>
    {
    }
}
