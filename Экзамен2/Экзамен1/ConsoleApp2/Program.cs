using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("G:\\File1.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f1);
            FileStream f2 = new FileStream("G:\\File2.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(f2);
            string f = rd.ReadToEnd();
            Console.WriteLine(f);
            for (int i = f.Length - 1; i >= 0; i--)
                wr.Write(f[i]);
            Console.ReadKey(true);
            rd.Close();
            wr.Close();
        }
    }
}
