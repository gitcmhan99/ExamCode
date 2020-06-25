using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _072_Array_Func1
 * DESC: 함수 파라미터로 배열 처리(CallbyRefrence)
-----------------------------------------------------------------------------*/
namespace _072_Array_Func1
{
    class Program
    {
        static void SwapArray(int oriIndex, int desIndex, int[] array) {
            int temp = array[oriIndex];
            array[oriIndex] = array[desIndex];
            array[desIndex] = temp;
        }

        static void Main(string[] args) {
            int[] arrNum = new int[]{1, 2, 3, 4};

            foreach(int temp in arrNum)
                Console.WriteLine("  {0}", temp);

            SwapArray(0, 1, arrNum);

            Console.WriteLine("");

            foreach(int temp in arrNum)
                Console.WriteLine("  {0}", temp);

        }
    }
}
