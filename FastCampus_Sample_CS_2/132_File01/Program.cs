using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

/*-----------------------------------------------------------------------------
 * Name: _132_File01
 * DESC: File클래스 기초
 * -----------------------------------------------------------------------------*/
namespace _132_File01
{
    class Program
    {
        static void Main(string[] args) {
            string path = "";

            if(args.Length <= 0) {
                path = Directory.GetCurrentDirectory();
                path += "\\a.txt";

                Console.WriteLine("path: " + path);
            }
            else {
                path = args[0];
            }

            if(File.Exists(path)) { //using System.IO;
                Console.WriteLine("\nGetCreationTime: " + File.GetCreationTime(path));
            }
            else {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            FileInfo fileInfo = new FileInfo("b.txt");
            FileStream ff = fileInfo.Create();

            ff.Close();
        }
    }
}
