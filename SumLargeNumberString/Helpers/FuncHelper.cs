using System.Linq;

namespace SumLargeNumberString.Helpers
{
    public static class FuncHelper
    {
        public static string Sum(string val1, string val2)
        {
            string strResult = "";

            var arrStr1 = val1.Reverse().ToArray();
            var arrStr2 = val2.Reverse().ToArray();

            if (arrStr1.Length < arrStr2.Length)
            {
                (arrStr1, arrStr2) = (arrStr2, arrStr1);
            }

            int arrStr1Length = arrStr1.Length;
            int arrStr2Length = arrStr2.Length;

            var carry = 0;
            for (int str1Index = 0; str1Index < arrStr1Length; str1Index++)
            {
                var num1 = (int)(arrStr1[str1Index] - '0');
                var num2 = (str1Index < arrStr2Length ? (int)(arrStr2[str1Index] - '0') : 0);
                var sum2Char = num1 + num2 + carry;
                carry = sum2Char / 10;
                var correctNum = (char)(sum2Char % 10 + '0');
                strResult += correctNum;
            }

            if (carry > 0)
            {
                strResult += (char)(carry + '0');
            }

            return new string(strResult.Reverse().ToArray());
        }
    }
}