using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _071_Array_Flex
 * DESC: 가변 배열
-----------------------------------------------------------------------------*/
namespace _071_Array_Flex
{
    class Program
    {
        static void Main(string[] args) {
            int[][] arrNum = new int[3][];

            arrNum[0] = new int[2] { 0, 1 };
            arrNum[1] = new int[4] { 0, 1, 2, 3 };
            arrNum[2] = new int[]{0, 1, 2};

            Console.WriteLine("=== arrNum ===");

            foreach(int[] arr in arrNum) {
                foreach(int data in arr) {
                    Console.Write("  {0}", data);
                }
                Console.WriteLine();
            }

            for(int i = 0; i < arrNum.Length; i++) {
                for(int j = 0; j < arrNum[i].Length; j++) {
                    Console.Write("  {0}", arrNum[i][j]);
                }
                Console.WriteLine();
            }

            int[][] arrNum2 = new int[2][]{
                new int[]{0, 1},
                new int[3] {0, 1, 2}};

            Console.WriteLine("=== arrNum2 ===");

            foreach(int[] arr in arrNum2) {
                foreach(int data in arr) {
                    Console.Write("  {0}", data);
                }
                Console.WriteLine();
            }
        }
    }
}
