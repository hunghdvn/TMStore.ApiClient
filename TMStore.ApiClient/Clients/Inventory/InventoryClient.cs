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
                if (!result.success)
                {
                    throw new Exception(result.errorCode + ": " + result.message);
                }
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object TaoPhieuKiemKho(string storeCode, string note, List<ProductOptionModel> details)
        {
            try
            {
                if (storeCode.IsEmpty())
                {
                    throw new Exception("Chưa có mã kho");
                }
                if (details.IsEmpty())
                {
                    throw new Exception("Không có chi tiết");
                }
                var result = ApiHelper.Post<BaseResponse<object>>("api/Inventories/checkBalanceOptinalProduct", new CheckBalanceRequest { note = note, storeCode = storeCode, details = details });
                if (!result.success)
                {
                    throw new Exception(result.errorCode + ": " + result.message);
                }
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object TaoPhieuKiemToanBo(string storeCode, string note, List<ProductOptionModel> details)
        {
            try
            {
                if (storeCode.IsEmpty())
                {
                    throw new Exception("Chưa có mã kho");
                }
                if (details.IsEmpty())
                {
                    throw new Exception("Không có chi tiết");
                }
                var result = ApiHelper.Post<BaseResponse<ConfirmExportResponse>>("api/Inventories/checkBalanceEntireWareHouse", new CheckBalanceRequest { note = note, storeCode = storeCode, details = details });
                if (!result.success)
                {
                    throw new Exception(result.errorCode + ": " + result.message);
                }
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ConfirmExportResponse XacNhanNhapKho(string note, int internalDeliveryId, List<string> rfids)
        {
            try
            {
                if (internalDeliveryId <= 0)
                {
                    throw new Exception("Chưa có internalDeliveryId");
                }
                if (rfids.IsEmpty())
                {
                    throw new Exception("Không có rfids");
                }
                var result = ApiHelper.Post<BaseResponse<ConfirmExportResponse>>("api/Inventories/confirmExport", new ConfirmExportRequest { note = note, internalDeliveryID = internalDeliveryId, rfIds = rfids });
                if (!result.success)
                {
                    throw new Exception(result.errorCode + ": " + result.message);
                }
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

                var result = ApiHelper.Post<BaseResponse<List<ExportResult>>>("api/Inventories/export", new ExportRequest { storeCode = storeCode, gate = gate, note = note, storeDestination = storeDestination, rfIds = rfIds });
                if (!result.success)
                {
                    throw new Exception(result.errorCode + ": " + result.message);
                }
                return result.data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
