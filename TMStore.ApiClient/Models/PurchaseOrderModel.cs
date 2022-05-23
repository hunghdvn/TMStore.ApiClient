using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class PurchaseOrderModel
    {
        public int importID { get; set; }
        public string storeCode { get; set; }
        public string po { get; set; }
        public List<PurchaseOrderDetailModel> details { get; set; }
    }

    public class PurchaseOrderDetailModel
    {
        public string externalSku { get; set; }
        public string productName { get; set; }
        public string url { get; set; }
        public int quantity { get; set; }
    }
}
