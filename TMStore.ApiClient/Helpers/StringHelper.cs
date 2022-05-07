namespace TMStore.ApiClient.Helpers
{
    public static class StringHelper
    {
        public static bool IsEmpty(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static bool IsNotNull(this string input)
        {
            return !IsEmpty(input);
        }
    }
}
