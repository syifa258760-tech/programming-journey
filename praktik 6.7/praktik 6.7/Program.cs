using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                // Tampilan menu
                Console.WriteLine("\n=== Menu aplikasi");
                Console.WriteLine("1. Lihat data");
                Console.WriteLine("2. Tambah data");
                Console.WriteLine("3. Keluar");
                Console.WriteLine("MAsukan pilihan anda (1-3): ");

                // Baca input pengguna
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid. Harap masukan anagka 1, 2, atau 3.");
                    // Tetapkan nilai selain 3 agar loop berlanjut 
                    pilihan = 0;
                    continue;
                }

                // Proses pilihan
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat data. ");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: tambah data. ");
                        break;
                    case 3:
                        Console.WriteLine("program akan berhenti ");
                        break; //keluar dari switch
                    default:
                        Console.WriteLine("pilihan di laur jangkauan. harap masukkan 1,2 atau 3.");
                        break;
                }
                //kondisi loop: lanjutkan selama pilihan bukan 3.
            } while (pilihan != 3);
            Console.WriteLine("terima kasih telah mengguakan aplikasi.");
        }
    }
}
