using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_boxung3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toadoA, toadoB;
            float[] A, B;
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("Nhap toa do diem A. vd: (5,9) hay 5,9 : \t\t");
            toadoA = Console.ReadLine().Replace('(', ' ').Replace(')', ' ').Split(',');
            Console.WriteLine("Ban chon toa do diem \t\t\t\t\tA(" + toadoA[0] + "," + toadoA[1] + ")");

            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("Nhap toa do diem B. vd: (5,9) hay 5,9 : \t\t");
            toadoB = Console.ReadLine().Replace('(', ' ').Replace(')', ' ').Split(',');
            Console.WriteLine("Ban chon toa do diem \t\t\t\t\tB(" + toadoB[0] + "," + toadoB[1] + ")");

            Console.WriteLine("---------------------------------------------------------------");
            A = Array.ConvertAll(toadoA, float.Parse);
            B = Array.ConvertAll(toadoB, float.Parse);
            Console.WriteLine("Khoang cach hai diem A B la : {0} ", Math.Sqrt((Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2))));

            Console.ReadKey();


        }
    }
}
