using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik7._2_fungsi_syifa_maulana_xpplg2
{
    internal class Program
    {
        static void sapanama(string nama)
        {
            Console.WriteLine("halo, " + nama + "!");
            Console.WriteLine("semangat belajar C# hari ini");
        }
        static void Main(string[] args)
        {
            Console.Write("masukkan nama anda: ");
            string namasiswa = Console.ReadLine();
            sapanama(namasiswa); // memanggil fungsi dengan argumen
        }
    }
}
