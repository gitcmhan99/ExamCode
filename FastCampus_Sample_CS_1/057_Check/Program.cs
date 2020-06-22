using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                int inputNum = int.Parse(Console.ReadLine());

                if (maxNum < inputNum)
                    maxNum = inputNum;

                if (minNum > inputNum)
                    minNum = inputNum;
            }

            Console.WriteLine("최대값:  {0}   최소값:  {1}", maxNum, minNum);
        }
    }
}
