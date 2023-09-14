using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoc004
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap so tien ban dau : ");
            int sotienBD = int.Parse(Console.ReadLine());
            int tieuphi , tong =0;
            
            do
            {
                Console.Write("Nhap so tien tieu phi : ");
                tieuphi = int.Parse(Console.ReadLine());
                if (tieuphi > 0)
                {
                    tong += tieuphi;
                }
            } while (tieuphi>0);
            

            int sodu = sotienBD - tong;
            Console.Write("So tien con lai la : " + sodu);

            Console.ReadKey();
        }
    }
}
