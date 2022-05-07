using System;

namespace TMStore.ApiClient.Models
{
    public class TokenPayload
    {
        public string jti { get; set; }
        public string nameid { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public long exp { get; set; }
        public long iat { get; set; }
        public long nbf { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }
    }
}
