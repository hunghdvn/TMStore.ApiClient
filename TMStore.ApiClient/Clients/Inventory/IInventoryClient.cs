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
    }
}
