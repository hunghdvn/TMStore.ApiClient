using System.Collections.Generic;

namespace TMStore.ApiClient.Models
{
    public class ProductModel
    {
        public int printQuantity { get; set; }
        public int productOptionId { get; set; }
        public List<string> rfids { get; set; }
    }
}
