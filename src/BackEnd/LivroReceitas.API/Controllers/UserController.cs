using LivroReceitas.Communication.Request;
using LivroReceitas.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace LivroReceitas.API.Controllers;

[Route("v1/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public async Task<IActionResult> Register(RequestRegisterUserJson request)
    {
        return Created();
    }
}