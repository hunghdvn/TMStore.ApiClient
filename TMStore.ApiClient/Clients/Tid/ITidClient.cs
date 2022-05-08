using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface ITidClient
    {
        /// <summary>
        /// Tìm kiếm sản phẩm trong kho bằng ProductOption
        /// </summary>
        /// <param name="externalSku"></param>
        /// <param name="productOptionId"></param>
        /// <param name="storeCode"></param>
        /// <returns></returns>
        TidProductModel GetTidByProductOption(string externalSku, int productOptionId, string storeCode);

        /// <summary>
        /// Tìm kiếm sản phẩm trong kho bằng Product
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="storeCode"></param>
        /// <returns></returns>
        List<TidProductModel> GetTidByProduct(string productCode, string storeCode);
    }
}
