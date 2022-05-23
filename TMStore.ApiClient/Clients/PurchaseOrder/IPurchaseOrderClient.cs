using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IPurchaseOrderClient
    {
        List<PurchaseOrderModel> GetImport(string storeCode);
    }
}
