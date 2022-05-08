using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IInventoryAdjustmentClient
    {
        List<ProductOptionModel> GetListByStoreCode(string storeCode);
    }
}
