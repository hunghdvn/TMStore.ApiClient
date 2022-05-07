using JWT;
using JWT.Serializers;
using System;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Helpers
{
    public class TokenHelper
    {
        public static DateTime GetExpireTime()
        {
            var token = ClientHelper.GetToken();
            if (token.IsEmpty())
            {
                throw new Exception("Chưa có token");
            }
            var serializer = new JsonNetSerializer();
            var urlEncode = new JwtBase64UrlEncoder();
            var decode = new JwtDecoder(serializer, urlEncode);
            var payload = decode.DecodeToObject<TokenPayload>(token);
            return DateTimeOffset.FromUnixTimeSeconds(payload.exp).LocalDateTime;
        }
    }
}
