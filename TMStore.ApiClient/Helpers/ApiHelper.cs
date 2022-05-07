using RestSharp;
using System;
using System.Net;

namespace TMStore.ApiClient.Helpers
{
    public class ApiHelper
    {
        private static void CheckToken(string token)
        {
            if (token.IsEmpty())
            {
                throw new Exception("Chưa có token");
            }
            if (TokenHelper.IsExpire())
            {
                TokenHelper.RefreshToken();
            }
        }

        public static T Get<T>(string url)
        {
            var client = ClientHelper.GetClient();
            var token = ClientHelper.GetToken();
            CheckToken(token);
            var uri = new Uri(ClientHelper.GetBaseUrl() + url);
            var request = new RestRequest(uri, Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = JsonHelper.ConvertJsonToObject<T>(response.Content);
                return result;
            }
            else
            {
                throw new Exception(response.Content);
            }
        }

        public static T Post<T>(string url, object body)
        {
            var client = ClientHelper.GetClient();
            var token = ClientHelper.GetToken();
            CheckToken(token);
            var uri = new Uri(ClientHelper.GetBaseUrl() + url);
            var request = new RestRequest(uri, Method.POST);
            request.AddHeader("Authorization", "Bearer " + token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(body);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonHelper.ConvertJsonToObject<T>(response.Content);
            }
            else
            {
                throw new Exception(response.Content);
            }
        }
    }
}
