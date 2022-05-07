using RestSharp;
using System;

namespace TMStore.ApiClient.Helpers
{
    public class ClientHelper
    {
        private static string BaseUrl;
        private static string Token;
        public static string User;
        public static string Password;

        public static void SetBaseUrl(string baseUrl)
        {
            try
            {
                BaseUrl = baseUrl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetBaseUrl()
        {
            return BaseUrl;
        }

        public static void SetToken(string token)
        {
            try
            {
                Token = token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetToken()
        {
            return Token;
        }

        public static RestClient GetClient()
        {
            return new RestClient(BaseUrl);
        }
    }
}
