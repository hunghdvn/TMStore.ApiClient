using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class ProductOptionModel
    {
        public string imageURL { get; set; }
        public string externalSKU { get; set; }
        public int sum { get; set; }
        public int productOptionId { get; set; }
        public List<string> chipCode { get; set; }
        public string name { get; set; }
    }
}
