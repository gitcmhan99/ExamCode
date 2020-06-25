using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _113_throw
 * DESC: throw 기초
 * 조건 연산사에서 사용된다.
-----------------------------------------------------------------------------*/
namespace _113_throw
{
    class Program
    {
        static void ThrowFunc(int data) {
            if(data > 0) {
                Console.WriteLine("ThrowFunc data: " + data);
            }
            else {
                throw new Exception("data에 0이 입력되었습니다.");
            }
        }

        static int ThrowDivision(int a, int b) {
            if(a > 0 && b > 0)
                return a / b;
            else
                throw new Exception("0보다 작은 값은 불가합니다.");
        }

        static void Main(string[] args) {
            try {
                ThrowFunc(10);
                ThrowFunc(100);
                ThrowFunc(0);
                ThrowFunc(1000);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                Console.WriteLine("100/20: " + ThrowDivision(100, 20));
                Console.WriteLine("10/5: " + ThrowDivision(10, 5));
                Console.WriteLine("10/0: " + ThrowDivision(10, 0));
                Console.WriteLine("100/100: " + ThrowDivision(100, 100));
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            // ?, ??
            int? a = null;
            try {
                int b = a ?? throw new ArgumentNullException();
            }
            catch(ArgumentNullException e) {
                Console.WriteLine(e.Message);
            }

            // ?  :
            int result = 101;
            try {
                int checkNum = (result < 100) ? result : throw new Exception("100 이하만 가능");
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
