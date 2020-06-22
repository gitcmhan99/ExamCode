using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요?");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);

            Console.WriteLine("입력한 수는: " + num);
        }
    }
}
