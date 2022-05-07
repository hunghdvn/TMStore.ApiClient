using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class StoresClient : IStoresClient
    {
        private RestClient client = ClientHelper.GetClient();

        public List<StoresModel> GetListStores()
        {
            try
            {
                var token = ClientHelper.GetToken();
                if (token.IsEmpty())
                {
                    throw new Exception("Chưa có token");
                }
                var request = new RestRequest(ClientHelper.GetBaseUrl() + "Stores", Method.GET);
                request.AddHeader("Authorization", "Bearer " + token);
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = JsonHelper.ConvertJsonToObject<List<StoresModel>>(response.Content);
                    return result;
                }
                else
                {
                    throw new Exception(response.Content);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
