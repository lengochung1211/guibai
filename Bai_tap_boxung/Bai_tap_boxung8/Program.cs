using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sluong, gtien, stien;
            Console.WriteLine("Chuong tirnh ban hang");
            Console.WriteLine("--------------------------");
            Console.Write("Nhap thong tin mon hang : \t\t");
            Console.ReadLine ();
            Console.Write("So luong mon hang : \t\t\t");
            sluong = int.Parse(Console.ReadLine());
            Console.Write("Gia tien mon hang : \t\t\t");
            gtien = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");
            stien = sluong * gtien;
            Console.WriteLine("So tien thanh toan chua co VAT : \t{0}", stien);

            stien = stien + stien * 8 / 100;
            Console.WriteLine("Tong so tien thanh toan : \t\t{0}", stien);

            Console.ReadKey();

        }
    }
}
