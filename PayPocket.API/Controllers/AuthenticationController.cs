using Microsoft.AspNetCore.Mvc;
using PayPocket.API.Services;

namespace PayPocket.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{

    private readonly AuthenticationService _authenticationService;

    
    public AuthenticationController(AuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        
    }

    [HttpPost("send-email-link/{email}")]
    public async Task<ActionResult<Boolean>> SendMagiclink(string email)
    {
        var didSendMagicLink = await _authenticationService.SendMagiclink(email);
        return Ok(didSendMagicLink);
    }
    

}