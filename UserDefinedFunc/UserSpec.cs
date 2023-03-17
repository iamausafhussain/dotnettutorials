namespace UserDefinedFunc
{
    static class UserSpec
    {
        public static int CountDigit(this int value)
        {
            int count = 0;

            while (value != 0)
            {
                count++;
                value = value / 10;
            }
            return count;
        }

        public static string ReverseString(this string value)
        {
            string newString = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                char c = value[i];
                newString += c;
            }
            return newString;
        }

        public static int GetNextNumber(ref int value)
        {
            int resultValue = value;
            resultValue += 1;
            return resultValue;
        }
    }
}
