using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _103_GenericFunc
 * DESC: 일반화 함수 기초
-----------------------------------------------------------------------------*/
namespace _103_GenericFunc
{
    class Program
    {
        static void GenericPrint<T>(T data) {
            Console.WriteLine("data: {0}", data);
        }

        static void GenericPrint<T>(T[] arrData) {
            for(int i = 0; i < arrData.Length; i++) {
                Console.WriteLine("arrData: {0}", arrData[i]);
            }
        }

        static void Main(string[] args) {
            int a = 10;
            float b = 10.3f;
            string c = "Hello";

            int[] arrA = { 0, 1, 2, 3 };
            string[] arrB = { "A", "B", "C", "D" };

            GenericPrint(a);
            GenericPrint(b);
            GenericPrint(c);

            Console.WriteLine();
            GenericPrint(arrA);
            Console.WriteLine();
            GenericPrint(arrB);
        }
    }
}
