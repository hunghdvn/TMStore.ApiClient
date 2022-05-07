using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IAuthClient
    {
        bool Login(string email, string password);
    }
}
