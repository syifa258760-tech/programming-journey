using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas7._1_kali_m_syifa_maulana_xpplg2
{
    internal class Program
    {
        static double HitungKali(double angka1, double angka2, double angka3)
        {
            double hasil = angka1 * angka2 * angka3;
            return hasil;
        }
        static void Main(string[] args)
        {
            Console.Write("masukkan angka pertama : ");
            double angka1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Masukan angka kedua   : ");
            double angka2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Masukan angka ketiga   :");
            double angka3 = Convert.ToDouble(Console.ReadLine());


            double hasil = HitungKali(angka1, angka2, angka3);
            Console.WriteLine("Hasil perkalian = " + hasil);

        }
    }
}
