using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 100);
            int inputNum = 0;
            int check = 0;

            while(true)
            {
                Console.Write("0~99사이 어떤 숫자일까요(단, 0은 나가기)");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0) break;

                ++check;

                if (inputNum > rndNum)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else if(inputNum < rndNum)
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
                else
                {
                    Console.WriteLine("=== 정답 입니다. ==");
                    Console.WriteLine("총 {0}번 시도", check);
                    break;
                }
            }
        }
    }
}
