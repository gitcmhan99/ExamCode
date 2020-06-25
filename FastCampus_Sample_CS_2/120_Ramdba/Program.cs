using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _120_Ramdba
 * DESC: Ramdba 기초
-----------------------------------------------------------------------------*/
namespace _120_Ramdba
{
    delegate void dPrint(string str);
    delegate int dAdd(int a);

    class Program
    {
        static public void CallPrint(string str) {
            Console.WriteLine(str);
        }

        static public int CallAdd(int a) {
            return a + a;
        }

        static void Main(string[] args) {
            dPrint dp = CallPrint;
            dp("CallPrint");
            dp = (str) => { Console.WriteLine(str); };
            dp("Ramdba");

            dAdd da = CallAdd;
            Console.WriteLine("CallAdd: " + da(10));
            da = (a) => { return a + a; };
            Console.WriteLine("Ramdba: " + da(10));
        }
    }
}
