using System;
using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class InventoryModel
    {
        public string storeCode { get; set; }
        public string gate { get; set; }
        public string note { get; set; }
        public DateTime licenseDateDt { get; set; }
        public List<ProductModel> products { get; set; }
    }


}
