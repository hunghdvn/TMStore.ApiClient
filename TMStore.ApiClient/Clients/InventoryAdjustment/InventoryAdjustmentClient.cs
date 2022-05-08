using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class InventoryAdjustmentClient : IInventoryAdjustmentClient
    {
        public List<ProductOptionModel> GetListByStoreCode(string storeCode)
        {
            try
            {
                var response = ApiHelper.Get<InventoryAdjustmentResponse>("api/InventoryAdjustment?storeCode=" + storeCode);
                if (response == null)
                {
                    return null;
                }
                return response.productOptions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
