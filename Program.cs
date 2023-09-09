using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin chao");

            Console.Write("moi ban nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            sochinhphuong(a);
            songuyento(a);
            sohoanhao(a);
            Console.WriteLine("a! = " + giaithua(a));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Moi nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("tong cac chu so = " + tongso(n));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int x;
            do
            {
                Console.Write("Nhap so :");
                x = int.Parse(Console.ReadLine());
            } while (x < 0);




            Console.ReadKey();
        }
        static void sochinhphuong(int a)
        {
            int cp = (int)Math.Sqrt(a);
            if (cp * cp == a)
            {
                Console.WriteLine("a = " + a + " la so chinh phuong");
            }
            else
            {
                Console.WriteLine("a = " + a + " khong la so chinh phuong");
            }
        }
        static void songuyento(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i != 0)
                {
                    Console.WriteLine("a = " + a + " la so nguyen to");
                    break;
                }
                else
                {
                    Console.WriteLine("a = " + a + " khong la so nguyen to");
                    break;
                }
            }
        }
        static void sohoanhao(int a)
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == a)
            {
                Console.WriteLine("a = " + a + " la so hoan hao");
            }
            else
            {
                Console.WriteLine("a = " + a + " khong la so hoan hao");
            }
        }
        static int giaithua(int a)
        {
            int gt = 1;
            for (int i = a; i >= 1; i--)
            {
                gt *= i;
            }
            return gt;
        }
        static int tongso(int n)
        {
            int sum = 0;
            for (int i = n; i > 0; i /= 10)
            {
                sum += i % 10;
            }
            return sum;
        }
    }
}
