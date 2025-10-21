using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            //blok 'do' akan dieksekusi minimal satu kali
            do
            {
                Console.WriteLine("masukkan angka genap: ");
                //mencoba membeaca input dari pengguna 
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                   Console.WriteLine("input tidak valid. silahkan masukkan angka.");
                   //jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut
                   angka = 1;
                   continue; //lanjutkan ke iterasi berikutnya
                }
                   //memeriksa apakah angka tersebut ganjil
                    if (angka % 2 != 0) 
                    {
                      Console.WriteLine($"angka {angka} adalah ganjil. coba lagi.");
                    }
                 //kondisi diperiksa di akhir.loop berlanjut selama angka ganjil.
                    } while (angka % 2 != 0);
                      Console.WriteLine($" selamat! anda memasukan angka genap: (angka)");
        }
    }
}
