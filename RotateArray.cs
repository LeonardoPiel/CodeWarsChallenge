using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenge
{
    //Exercise from Turing's Challenge
    public class RotateArray
    {
        public static int[] Rotate(int[] arr, int k)
        {
            int aux = 0;
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                aux = arr[i];
                arr[i] = arr[j];
                arr[j] = aux;
            }
            return arr;
        }
    }
}
