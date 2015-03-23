namespace _01.StringBuilderExtension
{
    using System.Text;
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(input[index]);
                index++;
            }

            return result;
        }
    }
}
