using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _085_class_has_a
 * DESC: 오버라이딩(다형성): 
 * 같은 기능을 하는 함수를 오버라이딩해서 객체가 가지는 소러 특성으로 실행하는 것이 가능
-----------------------------------------------------------------------------*/
namespace _085_class_has_a
{
    class AA
    {
        private int num;

        public void SetNum(int num) {
            this.num = num;
        }

        public void Print() {
            Console.WriteLine("num:  " + num);
        }
    }

    class BB
    {
        AA[] aa;

        public BB() {
            aa = new AA[5];
        }

        public void SetNum(int index, int num) {
            if(index < aa.Length) {
                aa[index] = new AA();
                aa[index].SetNum(num);
            }
        }

        public void Print() {
            for(int i = 0; i < aa.Length; i++) {

                if(null != aa[i])
                    aa[i].Print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            BB bb = new BB();
            bb.SetNum(0, 0);
            bb.SetNum(1, 100);
            bb.SetNum(2, 200);
            bb.SetNum(3, 200);

            bb.Print();
        }
    }
}
