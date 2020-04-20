namespace domain.utils
{
    public static class StringUtils
    {
        public static string Capitalize(this string target)
        {
            if (target.Length <= 1)
            {
                return target.ToUpper();
            }

            return $"{target.Substring(0, 1).ToUpper()}{target.Substring(1).ToLower()}";
        }
    }
}