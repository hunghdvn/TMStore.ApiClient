using System.Collections.Generic;

namespace TMStore.ApiClient.Clients
{
    public class BaseResponse<T>
    {
        public T data { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public List<object> errors { get; set; }
        public string errorCode { get; set; }
    }
}
