using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class TidProductModel
    {
        public int productOptionID { get; set; }
        public string externalSKU { get; set; }
        public string productCode { get; set; }
        public int productId { get; set; }
        public List<string> rfid { get; set; }
    }
}
