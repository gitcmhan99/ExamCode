using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _063_FuncSwap
 * DESC: 함수 기초: 리턴형 O, 파라미터 O(2개 이상의 파라미터)
-----------------------------------------------------------------------------*/
namespace _063_Func_out
{
    class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a;
            int b;

            InitNum(out a);
            Console.WriteLine("a: " + a);

            //b = 0;
            InitRefNum(ref b); //오류: b를 초기화 하지 않고 사용 불가!!
            Console.WriteLine("b: " + b);
        }
    }
}
