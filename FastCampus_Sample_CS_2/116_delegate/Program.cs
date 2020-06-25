using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _116_delegate
 * DESC: delegate 기초
-----------------------------------------------------------------------------*/
namespace _116_delegate
{
    delegate int DelegateFunc(int a);

    class Program
    {
        static int Add(int a) {
            Console.WriteLine("Add");
            return a + a;
        }

        static void Main(string[] args) {
            DelegateFunc delegateFunc = Add; //delegateFunc(Add)
            Console.WriteLine("delegateFunc: " + delegateFunc(10));
        }
    }
}
