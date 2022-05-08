using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IGoodsDeliveryNoteClient
    {
        /// <summary>
        /// Lấy danh sách phiếu xuất kho theo điểm nhận
        /// </summary>
        /// <param name="storeCode"></param>
        /// <returns></returns>
        List<GoodsDeliveryNoteModel> GetListByStoreCode(string storeCode);

        /// <summary>
        /// Lấy thông tin phiếu xuất theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        GoodsDeliveryNoteModel GetById(int id);
    }
}
