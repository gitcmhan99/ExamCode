using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*-----------------------------------------------------------------------------
 * Name: _134_File_StreamWriterReader
 * DESC: StreamWriter, StreamReader
 * -----------------------------------------------------------------------------*/
namespace _134_File_StreamWriterReader
{
    class Program
    {
        static void Main(string[] args) {
            //쓰기..
            FileStream fsWrite = new FileStream("a.txt", FileMode.Create);  // File.Create("a.txt");
            StreamWriter sw = new StreamWriter(fsWrite); //StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));

            sw.Write("Hello World");
            sw.WriteLine(" Line ");
            sw.WriteLine(" Line ");
            sw.Write(" Close ");

            sw.Close();



            //읽기..
            FileStream fsRead = File.Open("a.txt", FileMode.Open); //new FileStream("a.txt", FileMode.Open);  // File.Create("a.txt");
            StreamReader sr = new StreamReader(fsRead);

            Console.WriteLine("sr.BaseStream.Length:" + sr.BaseStream.Length);

            while(false == sr.EndOfStream) {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            //-----------------------------------------------
            //StreamWriter, StreamReader 단독 사용
            //-----------------------------------------------
            StreamWriter streamWriter = new StreamWriter("b.txt");

            streamWriter.WriteLine("A");
            streamWriter.WriteLine("B");
            streamWriter.WriteLine("C");
            streamWriter.WriteLine("D");

            streamWriter.Close();

            StreamReader streamReader = new StreamReader("b.txt");

            while(false == streamReader.EndOfStream) {
               Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();

            //IDisposable상속 받은 StreamReader를 using으로 활용..
            //using(StreamReader streamReader = new StreamReader("b.txt")) {
            //    while(false == streamReader.EndOfStream) {
            //       Console.WriteLine(streamReader.ReadLine());
            //    }
            //}
        }
    }
}
