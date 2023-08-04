using CqrsPattern.Models;
using CqrsPattern.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public  async  Task<List<Book>> GetAllBooks()
        {
            return await _mediator.Send(new GetAllBooksQuery());
        }
    }
}
