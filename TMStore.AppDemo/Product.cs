using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMStore.ApiClient.Models;

namespace TMStore.AppDemo
{
    public class Product
    {
        public List<ProductModel> GetListProduct()
        {
            return new List<ProductModel>
            {
                new ProductModel{
                     printQuantity = 2,
                     productOptionId = 142071,
                      rfids = new List<string> { "IDCHIP005", "IDCHIP006" }
                } };
        }
    }
}
