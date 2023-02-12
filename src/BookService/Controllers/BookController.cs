using Microsoft.AspNetCore.Mvc;

namespace BooksService;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    public List<Book> GetBooks()
    {
        return new()
        {
            new Book {Id=1 , Title="DDD" , Price=200},
            new Book {Id=2 , Title="Clean Arch" , Price=100},
            new Book {Id=3 , Title="Microservices" , Price=350},
        };
    }
}
