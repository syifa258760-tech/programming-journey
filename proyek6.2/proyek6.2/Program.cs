using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyek6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variabel untuk menyimpan hasil penjumlahan
            int total = 0;

            Console.WriteLine("menghitung jumlah angka dari 1 sampai 5");

            //perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++) 
            {
            //tambahkan nilai i saat ini ke variabel total
            total = total + i; // bisa juga ditulis sebagai: total += i;

            //tampilkan proses perjuangan di setiap langkah 
            Console.WriteLine("menambahkan" + i + ", total sementara = " + total);
            }
            //tampilkan hasil akhir setelah perulangan selesai
            Console.WriteLine("\nhasil akhir penjumlahan adalah: + total");
            }
        }
    }

