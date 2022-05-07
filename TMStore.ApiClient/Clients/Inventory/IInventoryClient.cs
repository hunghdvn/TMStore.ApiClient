using System;
using System.Collections.Generic;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public interface IInventoryClient
    {
        InventoryModel NhapKho(string storeCode, string gate, string note, DateTime licenseDateDt, List<ProductModel> products);
        List<ExportResult> XuatKho(string storeCode, string storeDestination, string note, string gate, List<string> rfIds);
    }
}
