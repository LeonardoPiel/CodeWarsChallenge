using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class ReverseStrings
    {
        public static string Revert(string input)
        {
            var arr = input.ToCharArray();
            var i = arr.Length - 1;
            var newWord = string.Empty;
            foreach (var c in arr) 
            {
                newWord += arr[i].ToString();
                i --;
            }
            return newWord;
        }
    }
}
