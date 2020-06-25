using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

/*-----------------------------------------------------------------------------
 * Name: _137_File_Binary
 * DESC: BinaryWriter, BinaryReader 기초
 * using문 활용하기
 * using System.IO;
 * using System.Runtime.Serialization.Formatters.Binary;
 * -----------------------------------------------------------------------------*/
namespace _137_File_Binary
{
    using CCPS = CustomClassPlayerSpecial;

    class CustomClassPlayerSpecial
    {
        public int num;
    }

    class Program
    {
        static public string fileName = "data.dat";
        static public string fileName2 = "dataUsing.dat";

        static void Main(string[] args) {
            WriteData();
            ReadData();

            WrireDataUsing();
            ReadDataUsing();
        }

        static void WriteData() {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(100);
            bw.Write(100.001f);
            bw.Write("Hello World");
            bw.Write(true);

            bw.Close();
        }

        static void ReadData() {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int num = br.ReadInt32();
            float fNum = br.ReadSingle();
            string str = br.ReadString();
            bool isData = br.ReadBoolean();

            Console.WriteLine("num: " + num);
            Console.WriteLine("fNum: " +fNum);
            Console.WriteLine("str: " +str);
            Console.WriteLine("isData: " + isData);

            br.Close();
        }

        static void WrireDataUsing() {
            using(BinaryWriter bw = new BinaryWriter(new FileStream(fileName2, FileMode.Create))) {
                bw.Write(100);
                bw.Write(100.001f);
                bw.Write("Hello World");
                bw.Write(true);
            }
        }

        static void ReadDataUsing() {
            using(BinaryReader br = new BinaryReader(new FileStream(fileName2, FileMode.Open))) {
                int num = br.ReadInt32();
                float fNum = br.ReadSingle();
                string str = br.ReadString();
                bool isData = br.ReadBoolean();

                Console.WriteLine("num: " + num);
                Console.WriteLine("fNum: " + fNum);
                Console.WriteLine("str: " + str);
                Console.WriteLine("isData: " + isData);
            } //using키워드 => 자동으로 br.close();
        }

        static void TestUsing() {
            CCPS ccps = new CCPS();
            ccps.num = 100;
        }
    }
}
