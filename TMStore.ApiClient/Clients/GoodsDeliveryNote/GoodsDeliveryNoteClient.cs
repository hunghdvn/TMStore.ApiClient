using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class GoodsDeliveryNoteClient : IGoodsDeliveryNoteClient
    {
        public GoodsDeliveryNoteModel GetById(int id)
        {
            try
            {
                return ApiHelper.Get<GoodsDeliveryNoteModel>("api/GoodsDeliveryNote/GetById?id=" + id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GoodsDeliveryNoteModel> GetListByStoreCode(string storeCode)
        {
            try
            {
                return ApiHelper.Get<List<GoodsDeliveryNoteModel>>("api/GoodsDeliveryNote?storeCode=" + storeCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
