using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _123_Action
 * DESC: Action 기초
-----------------------------------------------------------------------------*/
namespace _123_Action
{
    class Program
    {
        static void CallAction() {
            Console.WriteLine("CallAction");
        }

        static void Main(string[] args) {
            Action aFunc;
            Action<int> aFunc2;
            Action<float, int> aFunc3;

            aFunc = CallAction;
            aFunc2 = (num) => Console.WriteLine("num:" + num);
            aFunc3 = (a, b) => {
                float result = b / a;
                Console.WriteLine("a: " + a + " b:" + b + " result: " + result);
            };

            aFunc();
            aFunc2(100);
            aFunc3(6.0f, 10);
        }
    }
}
