using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2_fungsi_rata_rata___syifa_maulana_xpplg2
{
    internal class Program
    {
        static double RataRata(double nilai1, double nilai2, double nilai3)
        {
            double hasil = (nilai1 + nilai2 + nilai3) / 3;
            return hasil;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung rata rata nilai");

            Console.Write("Masuka nilai pertama : ");
            double nilai1 = double.Parse(Console.ReadLine());

            Console.Write("Masukan nilai kedua : ");
            double nilai2 = double.Parse(Console.ReadLine());

            Console.Write("Masukan nilai ketiga : ");
            double nilai3 = double.Parse(Console.ReadLine());

            double hasil = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Rata rata Nilai = " + hasil);
        }
    }
}
