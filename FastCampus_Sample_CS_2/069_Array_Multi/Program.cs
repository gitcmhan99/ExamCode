using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _069_Array_Multi
 * DESC: 다차원 배열 기본
-----------------------------------------------------------------------------*/
namespace _069_Array_Multi {
    class Program 
    {
        static void Main(string[] args) 
        {
            int[,] arrNum = new int[3, 2];

            arrNum[0, 0] = 1;
            arrNum[0, 1] = 2;

            arrNum[1, 0] = 3;
            arrNum[1, 1] = 4;

            arrNum[2, 0] = 5;
            arrNum[2, 1] = 6;

            foreach(int temp in arrNum) {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine();
        }
    }
}
