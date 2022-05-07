using RestSharp;
using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class StoresClient : IStoresClient
    {
        public List<StoresModel> GetListStores()
        {
            try
            {
                return ApiHelper.Get<List<StoresModel>>("api/Stores");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
