using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _081_01_classInheritance
 * DESC: 클래스 상속 기초..
-----------------------------------------------------------------------------*/
namespace _081_01_classInheritance
{
    class Super
    {
        protected int a;

        public void Print() {
            Console.WriteLine("Super Print()");
        }
    }

    class Sub:Super
    {
        int b;

        public void Print() {

            Console.WriteLine("Sub Print() a: {0}, b: {1}", a, b);
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Sub sub = new Sub();
            sub.Print();
        }
    }
}
