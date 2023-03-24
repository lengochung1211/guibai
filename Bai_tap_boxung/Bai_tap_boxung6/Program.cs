using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cc_cn;
            string thongtin;
            float[] cC_cN;
            float csBMI;
            Console.WriteLine("Chuong trinh tinh chi so BMI");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Ban hay nhap chieu cao (m) va can nang (kg). (vd: 1.5 45.2) : \t");
            cc_cn = Console.ReadLine().Split(' ');
            Console.WriteLine("Ban co chieu cao la : " + cc_cn[0] + "m. Can nang la : " + cc_cn[1] + "kg.");

            Console.WriteLine("--------------------------------------------");
            cC_cN = Array.ConvertAll(cc_cn, float.Parse);

            csBMI = cC_cN[1] / (cC_cN[0] * 2);
            Console.WriteLine("Chi so BMI la : {0}.", csBMI);
            thongtin = csBMI < 18.5 ? "thieu can." : csBMI <= 24.9 ? "binh thuong." : csBMI <= 29.9 ? "thua can." : "beo phi";

            Console.WriteLine("Hien gio ban dang " + thongtin);
            

            Console.ReadKey();

        }
    }
}
