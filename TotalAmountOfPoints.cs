using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    public class TotalAmountOfPoints
    {
        public static int TotalAmout(string[] games)
        {
            var points = new int();
            foreach (var game in games) 
            {
                var matchResult = game.Split(':');
                var xGols = Convert.ToInt32(matchResult[0]);
                var yGols = Convert.ToInt32(matchResult[1]);
                if (xGols > yGols) points += 3;
                else if (xGols == yGols) points += 1;
            }
            return points;
        }
    }
}
