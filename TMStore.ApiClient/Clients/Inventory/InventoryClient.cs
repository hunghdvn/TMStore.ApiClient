using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class InventoryClient : IInventoryClient
    {
        public InventoryModel NhapKho(string storeCode, string gate, string note, DateTime licenseDateDt, List<ProductModel> products)
        {
            try
            {
                if (storeCode.IsEmpty())
                {
                    throw new Exception("Chưa có mã kho");
                }
                if (gate.IsEmpty())
                {
                    throw new Exception("Chưa có gate");
                }
                if (note.IsEmpty())
                {
                    throw new Exception("Chưa có note");
                }
                if (products.IsEmpty())
                {
                    throw new Exception("Chưa có products");
                }

                var result = ApiHelper.Post<BaseResponse<InventoryModel>>("api/Inventories/input", new InventoryModel { storeCode = storeCode, gate = gate, note = note, licenseDateDt = licenseDateDt, products = products });
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportResult> XuatKho(string storeCode, string storeDestination, string note, string gate, List<string> rfIds)
        {
            try
            {
                if (storeCode.IsEmpty())
                {
                    throw new Exception("Chưa có mã kho");
                }
                if (storeDestination.IsEmpty())
                {
                    throw new Exception("Chưa có mã kho đích");
                }
                if (gate.IsEmpty())
                {
                    throw new Exception("Chưa có gate");
                }
                if (note.IsEmpty())
                {
                    throw new Exception("Chưa có note");
                }
                if (rfIds.IsEmpty())
                {
                    throw new Exception("Chưa có rfIds");
                }

                var result = ApiHelper.Post<BaseResponse<List<ExportResult>>>("api/Inventories/input", new ExportRequest { storeCode = storeCode, gate = gate, note = note, storeDestination = storeDestination, rfIds = rfIds });
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
