using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class GoodsDeliveryNoteModel
    {
        public int id { get; set; }
        public string note { get; set; }
        public string fromStoreCode { get; set; }
        public string toStoreCode { get; set; }
        public string exportType { get; set; }
        public List<ExportDetailModel> exportDetails { get; set; }
    }
}
