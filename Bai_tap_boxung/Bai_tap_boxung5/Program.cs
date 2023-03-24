using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap vao mot so nguyen : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("So ban vua chon la so {0}", a % 2 == 0 ? "chan" : "le");
            Console.ReadKey();
                 
        }
    }
}
