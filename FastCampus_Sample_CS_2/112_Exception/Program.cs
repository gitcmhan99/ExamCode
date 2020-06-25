using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _112_Exception
 * DESC: Exception 기초
-----------------------------------------------------------------------------*/
namespace _112_Exception
{
    class Program
    {
        static void Main(string[] args) {
            int maxNum = 10;

            try {
                checked {
                    maxNum += Int32.MaxValue;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("e.Message: " + e.Message);
                Console.WriteLine("e.Source:" + e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
            Console.WriteLine("maxNum: " + maxNum);
        }
    }
}
