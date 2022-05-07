using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IAuthClient
    {
        /// <summary>
        /// Api đăng nhập kệ thống
        /// </summary>
        /// <param name="email">Email người dùng</param>
        /// <param name="password">Mật khẩu người dùng</param>
        /// <returns></returns>
        bool Login(string email, string password);
    }
}
