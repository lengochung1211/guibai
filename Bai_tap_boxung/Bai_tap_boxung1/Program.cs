using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            Console.Write("Nhap so nguyen thu nhat : \t");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai : \t");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu ba : \t");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            max = a;
            max = max < b ? b < c ? max = c : max = b : max < c ? max = c : max;
            Console.WriteLine("So nguyen lon nhat la : " + max);
            Console.ReadKey();
        }
    }
}
