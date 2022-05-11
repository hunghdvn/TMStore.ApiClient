using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class CheckBalanceRequest
    {
        public string storeCode { get; set; }
        public string note { get; set; }
        public List<ProductOptionModel> details { get; set; }
    }
}
