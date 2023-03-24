using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung7
{
    class Program
    {
        static void Main(string[] args)
        {
            string thong_tin, ho, tendem, ten;
            string[] thong_Tin;
            int skt, smang;
            Console.WriteLine("Chuong trinh hien thi thong tin nguoi dung.");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Nhap vao Ho va Ten : \t");
            thong_tin = Console.ReadLine();

            Console.WriteLine("-------------------------------------------");
            skt = thong_tin .Replace (" ", "").Length;
            Console.WriteLine("So ky tu nguoi dung : \t\t{0} ky tu", skt);

            thong_Tin = thong_tin.Split(' ');
            smang = thong_Tin.Length;
            ho = thong_Tin[0];
            tendem = smang == 2 ? " " : smang == 3 ? thong_Tin[1] : (thong_Tin[1] +" " + thong_Tin[2]);
            ten = thong_Tin[smang - 1];

            Console.WriteLine("Ho cua nguoi dung : \t\t" + ho );
            Console.WriteLine("Ten dem cua nguoi dung : \t" + tendem);
            Console.WriteLine("Ten cua nguoi dung : \t\t" + ten);
           
            Console.ReadKey();

        }
    }
}
