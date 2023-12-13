using Supabase.Core;
namespace PayPocket.API.Services;


public class SupabaseClientService
{
    private readonly string _url;
    private readonly string _key;
    public SupabaseClientService(string url, string key)
    {
        _url = url;
        _key = key;
        
        Console.WriteLine(url);
    }
    
    public async  Task<Supabase.Client> GetClient()
    {
        Console.WriteLine(_url);
        var options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };
        
        var supabase = new Supabase.Client(_url, _key, options);
        await supabase.InitializeAsync();
        return supabase;
    }
    
    
}