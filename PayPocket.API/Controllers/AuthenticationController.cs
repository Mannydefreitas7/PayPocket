using Microsoft.AspNetCore.Mvc;
using PayPocket.API.Services;

namespace PayPocket.API.Controllers;

public class AuthenticationController : ControllerBase
{

    private readonly SupabaseClientService _clientService;

    public AuthenticationController(SupabaseClientService clientService)
    {
        _clientService = clientService;
        

    }
    
    
    

}