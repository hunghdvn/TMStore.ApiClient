using System;
using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IInventoryClient
    {
        /// <summary>
        /// Gọi api nhập kho
        /// </summary>
        /// <param name="storeCode"></param>
        /// <param name="gate"></param>
        /// <param name="note"></param>
        /// <param name="licenseDateDt"></param>
        /// <param name="products"></param>
        /// <returns></returns>
        InventoryModel NhapKho(string storeCode, string gate, string note, DateTime licenseDateDt, List<ProductModel> products);

        /// <summary>
        /// Gọi api xuất kho
        /// </summary>
        /// <param name="storeCode"></param>
        /// <param name="storeDestination"></param>
        /// <param name="note"></param>
        /// <param name="gate"></param>
        /// <param name="rfIds"></param>
        /// <returns></returns>
        List<ExportResult> XuatKho(string storeCode, string storeDestination, string note, string gate, List<string> rfIds);

        /// <summary>
        /// Gọi api xác nhận nhập kho
        /// </summary>
        /// <param name="note"></param>
        /// <param name="internalDeliveryId"></param>
        /// <param name="rfids"></param>
        /// <returns></returns>
        ConfirmExportResponse XacNhanNhapKho(string note, int internalDeliveryId, List<string> rfids);

        /// <summary>
        /// Gọi api Tạo phiếu kiểm kho theo sản phẩm
        /// </summary>
        /// <param name="storeCode"></param>
        /// <param name="note"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        object TaoPhieuKiemKho(string storeCode, string note, List<ProductOptionModel> details);

        /// <summary>
        /// Gọi api Tạo phiếu kiểm toàn bộ
        /// </summary>
        /// <param name="storeCode"></param>
        /// <param name="note"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        object TaoPhieuKiemToanBo(string storeCode, string note, List<ProductOptionModel> details);
    }
}
