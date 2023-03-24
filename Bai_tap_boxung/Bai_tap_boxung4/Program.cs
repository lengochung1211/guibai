using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung4
{
    class Program
    {
        static void Main(string[] args)
        {
            float st, lai, kyhan;
            Console.WriteLine("--------------------------------------");
            Console.Write("Thong tin ngan hang :\t");
            Console.ReadLine();
            Console.WriteLine("--------------------------------------");

            Console.Write("So tien gui : \t\t");
            st = float.Parse(Console.ReadLine());
            Console.Write("Lai suat gui : \t\t");
            lai = float.Parse(Console.ReadLine());
            Console.Write("Ky han gui : \t\t");
            kyhan = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("So tien lai nhan duoc : {0}", st * lai * kyhan  / 1200);
            Console.WriteLine("Tong so tien nhan duoc : {0}", st + st * lai *kyhan  / 1200);

            Console.ReadKey();

        }
    }
}
