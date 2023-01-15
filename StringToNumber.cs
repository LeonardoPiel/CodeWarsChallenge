using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class StringToNumber
    {
        public static int Convert(String str)
        {
            var arr = str.ToArray();
            var total = 0;
            bool isNegative = false;
            if (arr.Contains('-')) {
                arr = arr.Where(e => e != '-').ToArray();
                isNegative = true;
            }
            var pot = arr.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var number = int.Parse(arr[i].ToString());
                total += number * (int) Math.Pow(10, pot - i);
            }
            if (isNegative) total *= -1;
            return total;
        }
    }
}
