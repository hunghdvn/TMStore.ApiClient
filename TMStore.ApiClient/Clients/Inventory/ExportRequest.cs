using System.Collections.Generic;

namespace TMStore.ApiClient.Clients
{
    public class ExportRequest
    {
        public string storeCode { get; set; }
        public string storeDestination { get; set; }
        public string note { get; set; }
        public string gate { get; set; }
        public List<string> rfIds { get; set; }
    }
}
