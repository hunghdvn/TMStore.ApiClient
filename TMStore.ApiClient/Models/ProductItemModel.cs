using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class ProductItemModel
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public List<ProductOptionModel> options { get; set; }

    }
}
