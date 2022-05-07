using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class ProductOptionResponse
    {
        public int totalPage { get; set; }
        public int pageSize { get; set; }
        public int page { get; set; }
        public int nextPage { get; set; }
        public int? previousPage { get; set; }
        public List<ProductItemModel> items { get; set; }
    }
}
