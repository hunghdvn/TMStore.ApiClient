using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IProductClient
    {
        ProductOptionResponse GetListProduct(string sku, int productId, int optionId, int optionId2, int page, int pageSize);
    }
}
