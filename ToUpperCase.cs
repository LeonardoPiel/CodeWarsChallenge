using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class ToUpperCase
    {
        private string Word { get; set; }
        public ToUpperCase(string value) 
        {
            Word = value;
        }
        public string toUpper()
        {
            return Word.ToUpper();
        }

    }
}
