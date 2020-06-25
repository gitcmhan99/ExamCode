using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _074_Array_Clear
 * DESC: 배열 관리 함수
-----------------------------------------------------------------------------*/
namespace _074_Array_Clear
{
    class Program
    {
        static void Main(string[] args) {
            int[] array = new int[3];

            Array.Clear(array, 0, array.Length);
            for(int i = 0; i < array.Length; i++) {
                array[i] = i;
            }

            for(int i = 0; i < array.Length; i++) {
                Console.Write("  {0}  ", array[i]);
            }

            Console.WriteLine("\n-----------------------------");

            int[,] arrNum = new int[3, 2];

            Console.WriteLine("\n-------  Array.Clear  -------");
            Array.Clear(arrNum, 0, arrNum.Length);

            for(int i = 0; i < arrNum.GetLength(0); i++) {
                for(int j = 0; j < arrNum.GetLength(1); j++) {
                    arrNum[i, j] = (i * arrNum.GetLength(1)) + j;
                }
            }

            for(int i = 0; i < arrNum.GetLength(0); i++) {
                for(int j = 0; j < arrNum.GetLength(1); j++) {
                        Console.Write("  " + arrNum[i, j]);
                }
                    Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            int[,,] arrMulti1 = new int[,,]{
                {{0, 1}, {2, 3}, {4, 5}},
                {{6, 7}, {8, 9}, {10, 11}},
                {{12, 13}, {14, 15}, {16, 17}},
                {{18, 19}, {20, 21}, {22, 23}}
            };

            Console.WriteLine("arrMulti1.Length: " + arrMulti1.Length);

            for(int i = 0; i < arrMulti1.GetLength(0); i++) {
                for(int j = 0; j < arrMulti1.GetLength(1); j++) {
                    for(int k = 0; k < arrMulti1.GetLength(2); k++) {
                        Console.Write("  " + arrMulti1[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            int[,,] cloneArray = (int[,,])arrMulti1.Clone();

            for(int i = 0; i < cloneArray.GetLength(0); i++) {
                for(int j = 0; j < cloneArray.GetLength(1); j++) {
                    for(int k = 0; k < cloneArray.GetLength(2); k++) {
                        Console.Write("  " + cloneArray[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            cloneArray[0, 0, 0] = 10000;
            Console.Write("\n arrMulti1[0, 0, 0]:  {0}  ", arrMulti1[0, 0, 0]);
            Console.Write("\n cloneArray[0, 0, 0]:  {0}  ", cloneArray[0, 0, 0]);
        }
    }
}
