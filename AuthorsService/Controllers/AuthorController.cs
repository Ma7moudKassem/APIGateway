using Microsoft.AspNetCore.Mvc;

namespace AuthorsService;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    [HttpGet]
    public List<Author> GetAuthors()
    {
        List<Author> authors = new()
        {
            new Author{Id = 1 , Name="Kassem" },
            new Author{Id = 2 , Name="Abdo" },
            new Author{Id = 3 , Name="Ahmed" },
        };
        return authors;
    }
}
