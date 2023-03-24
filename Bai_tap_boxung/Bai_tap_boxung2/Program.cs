using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nhietdoC;
            Console.WriteLine("Chuong trinh doi nhiet do C sang nhiet do F");
            Console .WriteLine ("-------------------------------------------");

            Console.Write("Nhap nhiet do C ma ban muon doi : ");
            nhietdoC = float.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nhiet do C \t\t\t\t\t\t Nhiet do F");
            Console.WriteLine("   " + nhietdoC + "\t\t\t\t\t\t\t    " + (1.8 * nhietdoC + 32));
            Console.ReadKey();
        }
    }
}
