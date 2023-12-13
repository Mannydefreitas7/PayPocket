using Supabase.Gotrue;

namespace PayPocket.API.Services;

public class AuthenticationService
{
    private readonly SupabaseClientService _clientService;

    public AuthenticationService(SupabaseClientService clientService)
    {
        _clientService = clientService;
        
    }
    
    public async Task<Boolean> SendMagiclink(string email)
    {
        var client = await _clientService.GetClient();
        var auth = client.Auth;
        var didSendMagicLink = await auth.SendMagicLink(email);
        return didSendMagicLink;
    }
    
}