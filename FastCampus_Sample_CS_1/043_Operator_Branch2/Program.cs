using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _043_Operator_Branch2
 * DESC: if(조건문): 조건문이 가지는 값은 true/false
 * if ~ else if ~ else
-----------------------------------------------------------------------------*/
namespace _043_Operator_Branch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            string strNum = Console.ReadLine();
            int a = int.Parse(strNum);

            if(a > 0)
            {
                Console.WriteLine("입력한 수는 양수!!");
            } 
            else if(a < 0)
            {
                Console.WriteLine("입력한 수 음수!!");
            }
            else
            {
                Console.WriteLine("입력한 수 0이다");
            }
        }
    }
}
