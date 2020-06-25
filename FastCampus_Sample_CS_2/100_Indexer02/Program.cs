using System;
using System.Collections;

/*-----------------------------------------------------------------------------
 * Name: _100_Indexer02
 * DESC: 
-----------------------------------------------------------------------------*/
namespace _100_Indexer02
{
    class AA
    {
        ArrayList arrayList = new ArrayList();

        public string this[int index]
        {
            get {
                if(index >= 0 && index < arrayList.Count)
                    return (string)arrayList[index];
                else
                    return null;
            }
            set {
                if(index >= 0 && index < arrayList.Count)
                    arrayList[index] = value;
                else if(index == arrayList.Count)
                    arrayList.Add(value);
            }
        }

        public int count {
            get { return arrayList.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            AA aa = new AA();
            for(int i = 0; i < 10; i++) {
                aa[i] = string.Format("{0}", i);
            }

            aa[0] = "Hello";
            aa[1] = "World";

            for(int i = 0; i < aa.count; i++) {
                Console.WriteLine("aa: " + aa[i]);
            }
        }
    }
}
