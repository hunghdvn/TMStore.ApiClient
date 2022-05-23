using System.Collections.Generic;

namespace TMStore.ApiClient.Clients
{
    public class ConfirmExportRequest
    {
        public string note { get; set; }
        public int internalDeliveryID { get; set; }
        public List<string> rfIds { get; set; }
    }
}
