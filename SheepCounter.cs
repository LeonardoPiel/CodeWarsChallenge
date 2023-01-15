using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class SheepCounter
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Where(e => e == true).Count();
       
    }
}
