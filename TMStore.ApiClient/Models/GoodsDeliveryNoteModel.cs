using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMStore.ApiClient.Models
{
    public class GoodsDeliveryNoteModel
    {
        public int id { get; set; }
        public string note { get; set; }
        public string fromStoreCode { get; set; }
        public string toStoreCode { get; set; }
    }
}
