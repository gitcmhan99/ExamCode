using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _036_Operator3
 * DESC: 산술 연산자, +,  -,  *,  /,  %, (모든 수치 데이터 형태)
-----------------------------------------------------------------------------*/
namespace _036_Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: {0}", num++); //후치 연산
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", ++num); //전치 연산

            Console.WriteLine("\nnum: {0}", num--); //후치 연산
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", --num); //전치 연산
        }
    }
}
