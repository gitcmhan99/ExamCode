using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _015_Data8
 * DESC: char형이 아스키 코드값을 사용 정수형 데이터와 같은 것
-----------------------------------------------------------------------------*/
namespace _015_Data8
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A'; //아스키 코드값: 65
            int num = a;

            Console.WriteLine("문자: {0}, 아스키코드값: {1}, 문자로 캐스트 연산: {2}", a, num, (char)num);
        }
    }
}
