using Microsoft.AspNetCore.Mvc;
using DynamicProfileAPI.Models;
using DynamicProfileAPI.Services;

namespace DynamicProfileAPI.Controller;

[ApiController]
[Route("[Controller]")]

public class MeController : ControllerBase 
{
    private readonly CatFactService _catFactService;

    public MeController(CatFactService catFactService)
    {
        _catFactService = catFactService;
    }
    [HttpGet("/me")]
    public async Task<IActionResult> GetProfile()
    {
        var user = new User
        {
            Name = "Oluwadamimola Adedeji",
            Email = "damimolaadedeji@gmail.com",
            Stack = "C# / .NET"
        };

        var fact = await _catFactService.GetRandomCatFactAsync();

        var response = new ProfileResponse
        {
            Status = "success",
            User = user,
            Timestamp = DateTime.UtcNow.ToString("o"),
            Fact = fact
        };

        return Ok(response);
    }

}
