using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IStoresClient
    {
        /// <summary>
        /// Lấy danh sách cửa hàng
        /// </summary>
        /// <returns></returns>
        List<StoresModel> GetListStores();
    }
}
