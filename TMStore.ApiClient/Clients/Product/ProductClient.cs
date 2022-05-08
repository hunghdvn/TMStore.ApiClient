using System;
using TMStore.ApiClient.Helpers;

namespace TMStore.ApiClient.Clients
{
    public class ProductClient : IProductClient
    {
        public ProductOptionResponse GetListProduct(string sku, int productId, int optionId, int optionId2, int page, int pageSize)
        {
            try
            {
                var result = ApiHelper.Get<ProductOptionResponse>($"api/ProductOption?sku={sku}&productId={productId}&optionId={optionId}&optionId2={optionId2}&page={page}&pageSize={pageSize}");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
