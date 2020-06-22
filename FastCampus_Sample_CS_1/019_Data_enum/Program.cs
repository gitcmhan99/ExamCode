using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _019_Data_enum
 * DESC: enum데이터형 기초
-----------------------------------------------------------------------------*/
namespace _019_Data_enum
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            THE,
            WED,
            THU,
            FRI,
            SAT,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THE, (int)DAY_OF_WEEK.THE);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.WED, (int)DAY_OF_WEEK.WED);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.THU, (int)DAY_OF_WEEK.THU);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.FRI, (int)DAY_OF_WEEK.FRI);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SAT, (int)DAY_OF_WEEK.SAT);
        }
    }
}
