using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IProductClient
    {
        /// <summary>
        /// Gọi api lấy danh sách Product
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="productId"></param>
        /// <param name="optionId"></param>
        /// <param name="optionId2"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        ProductOptionResponse GetListProduct(string sku, int productId, int optionId, int optionId2, int page, int pageSize);
    }
}
