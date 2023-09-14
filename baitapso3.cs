using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoc005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            ptlonthu2(n);
            Console.WriteLine();
            int m;
            do
            {
                Console.Write("Nhap m: ");
                m = int.Parse(Console.ReadLine());
            } while (m < 10);
            Console.Write("Tong S=11+22+nn+..= " + tong(m));

            Console.ReadKey();
        }
        static void ptlonthu2(int n)
        {
            int[] a = new int[n];
            int tg;
            for (int i = 0; i<n; i++){
                Console.Write("Nhap phan tu thu " +(i+1)+ " : " );
                a[i]= int.Parse(Console.ReadLine());
            } 
            for(int i = 0; i < n; i++){
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;
                    }          
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write("So lon thu 2 trong mang la :" + a[1]);
                break;
            }
        }
        static int tong(int m)
        {
            int tong = 0;
            for (int i = 1; i <= m; i++){
                tong += (i * 11);
            }
            return tong;
        }
    }
}
