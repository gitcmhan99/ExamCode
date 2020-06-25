using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _068_Array_Init
 * DESC: 일차원 배열 기본
-----------------------------------------------------------------------------*/
namespace _068_Array_Init
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];

            arrNum[0] = 1;
            arrNum[1] = 2;
            arrNum[2] = 3;

            for(int i = 0; i < 3; i++) {
                Console.Write("  {0}", arrNum[i]);
            }

            Console.WriteLine("\n arrNum.GetType():  {0}", arrNum.GetType());
        }
    }
}
