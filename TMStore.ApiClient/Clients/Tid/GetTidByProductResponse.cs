using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class GetTidByProductResponse
    {
        public string storeCode { get; set; }
        public string productCode { get; set; }
        public int productID { get; set; }
        public List<TidProductModel> productOptions { get; set; }
    }
}
