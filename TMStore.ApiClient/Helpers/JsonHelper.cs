using Newtonsoft.Json;

namespace TMStore.ApiClient.Helpers
{
    public class JsonHelper
    {
        public static T ConvertJsonToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }  
        
        public static string ConvertObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }    
    }
}
