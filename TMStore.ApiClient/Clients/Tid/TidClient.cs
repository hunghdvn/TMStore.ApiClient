using System;
using System.Collections.Generic;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class TidClient : ITidClient
    {
        public List<TidProductModel> GetTidByProduct(string productCode, string storeCode)
        {
            try
            {
                var response = ApiHelper.Get<GetTidByProductResponse>($"api/Tid/GetTidByProduct?productCode={productCode}&storeCode={storeCode}");
                if (response == null)
                {
                    return null;
                }
                foreach (var item in response.productOptions)
                {
                    item.productCode = productCode;
                }
                return response.productOptions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TidProductModel GetTidByProductOption(string externalSku, int productOptionId, string storeCode)
        {
            try
            {
                return ApiHelper.Get<TidProductModel>($"api/Tid/GetTidByProductOption?externalSKU={externalSku}&productOptionID={productOptionId}&storeCode={storeCode}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
