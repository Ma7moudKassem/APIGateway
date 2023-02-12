using Microsoft.AspNetCore.Mvc;

using System.Net.Http;
using System.Threading.Tasks;

namespace ApiGateway;

[Route("[action]")]
[ApiController]
public class ProxyController : ControllerBase
{
    private readonly HttpClient _httpClient;
    public ProxyController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet]
    public async Task<IActionResult> Books() => await ProxyTo("https://localhost:7194/api/Book");

    [HttpGet]
    public async Task<IActionResult> Authors() => await ProxyTo("https://localhost:7190/api/Author");

    private async Task<ContentResult> ProxyTo(string url)
            => Content(await _httpClient.GetStringAsync(url));
}
