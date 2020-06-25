using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _083_override
 * DESC: 오버라이딩(다형성): 
 * 같은 기능을 하는 함수를 오버라이딩해서 객체가 가지는 소러 특성으로 실행하는 것이 가능
-----------------------------------------------------------------------------*/
namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print(){
            Console.WriteLine("num:  {0}", num);
        }
    }

    class AA : Super
    {
        public int a;

        public override void Print() {
            base.Print();

            Console.WriteLine("AA a:  {0}", a);
        }
    }

    class BB : Super
    {
        public int b;

        public override void Print() {
            base.Print();

            Console.WriteLine("BB b:  {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Super super = new Super();
            super.Print();

            Super aa = new AA();
            aa.Print();

            Super bb = new BB();
            bb.Print();
        }
    }
}
