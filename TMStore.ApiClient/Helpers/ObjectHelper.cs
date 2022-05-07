using System.Collections.Generic;

namespace TMStore.ApiClient.Helpers
{
    public static class ObjectHelper
    {

        public static bool IsEmpty<T>(this ICollection<T> lst)
        {
            if (lst == null)
            {
                return true;
            }
            return lst.Count < 1;
        }

        public static bool IsNotEmpty<T>(this ICollection<T> lst)
        {
            return !lst.IsEmpty();
        }
    }
}
