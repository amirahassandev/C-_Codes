namespace TestCodes;

public static class NumberHelpers
{
    public static bool IsBetween(this int value, int min, int max)
    {
        return (value > min) && (value < max);
    }
}

public static class StringHelpers
{
    public static string ReverseStr(this string value)
    {
        char[] word = value.ToCharArray();
        Array.Reverse(word);

        return string.Join("", word);
    }

    public static string RemoveWhiteSpace(this string value)
    {
        return value.Replace(" ", "");
    }
    

}