using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _070_Array_Multi2
 * DESC: 일차원 배열 다양한 선언 및 초기화 방법
-----------------------------------------------------------------------------*/
namespace _070_Array_Multi2
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[,] arrNum = new int[3, 2];
            int[,] arrNum2 = new int[,] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            int[,] arrNum3 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach(int temp in arrNum2) {
                Console.Write("  " + temp);
            }
            Console.WriteLine("\narrMulti.Length: " + arrNum2.Length);

            foreach(int temp in arrNum3) {
                Console.Write("  " + temp);
            }
            Console.WriteLine("\narrMulti.Length: " + arrNum3.Length);

            int[,,] arrMulti = new int[4, 3, 2];
            int[,,] arrMulti1 = new int[,,]{
                {{0, 1}, {2, 3}, {4, 5}},
                {{6, 7}, {8, 9}, {10, 11}},
                {{12, 13}, {14, 15}, {16, 17}},
                {{18, 19}, {20, 21}, {22, 23}}
            };
            int[,,] arrMulti2 = new int[4, 3, 2]{
                {{0, 1}, {2, 3}, {4, 5}},
                {{6, 7}, {8, 9}, {10, 11}},
                {{12, 13}, {14, 15}, {16, 17}},
                {{18, 19}, {20, 21}, {22, 23}}
            };

            Console.WriteLine("arrMulti.Length: " + arrMulti.Length);
            Console.WriteLine("arrMulti1.Length: " + arrMulti1.Length);
            Console.WriteLine("arrMulti2.Length: " + arrMulti2.Length);

            foreach(int temp in arrMulti1) {
                Console.Write("  " + temp);
            }

            Console.WriteLine();

            foreach(int temp in arrMulti2) {
                Console.Write("  " + temp);
            }
        }
    }
}
