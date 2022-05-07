namespace TMStore.ApiClient.Models
{
    public class ExportDetailModel
    {
        public int id { get; set; }
        public int goodsDeliveryNoteId { get; set; }
        public decimal inputPrice { get; set; }
        public int quantity { get; set; }
        public int productOptionId { get; set; }
        public string barcode { get; set; }
        public string receiveQuantity { get; set; }
        public decimal salePrice { get; set; }
        public string productCode { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public string productOptionName { get; set; }
    }
}
