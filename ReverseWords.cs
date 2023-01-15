using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class ReverseWords
    {
        private string word { get; set; }
        public ReverseWords(string str)
        {
            word = str;
        }
        public string Reverse()
        {
            var arr = word.Split(" ");
            var reverse = string.Empty;
            
            for (int i = arr.Count() - 1; i >= 0; i--)
                reverse += arr[i] + " ";
            
            return reverse.TrimEnd();
        }
    }
}
