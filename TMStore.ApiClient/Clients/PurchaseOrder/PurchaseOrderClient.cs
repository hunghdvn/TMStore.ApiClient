using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class PurchaseOrderClient : IPurchaseOrderClient
    {
        public List<PurchaseOrderModel> GetImport(string storeCode)
        {
            try
            {
                var result = ApiHelper.Get<List<PurchaseOrderModel>>($"api/PurchaseOrder/GetImport?storeCode={storeCode}");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
