using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class InventoryAdjustmentResponse
    {
        public string storeCode { get; set; }
        public List<ProductOptionModel> productOptions { get; set; }
    }
}
