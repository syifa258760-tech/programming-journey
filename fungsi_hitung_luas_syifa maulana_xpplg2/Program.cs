using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fungsi_hitung_luas_syifa_maulana_xpplg2
{
    internal class Program
    {
        static double hitungluas(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("masukkan panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("masukkan lebar: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double hasil = hitungluas(p, l);
            Console.WriteLine("luas persegi panjang adalah: " + hasil);
        }
    }
}
