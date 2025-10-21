using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inisialisasi variabel untuk menyimpan input
            string inputuser = "";

            Console.WriteLine("program akan terus berjalan hingga anda mengetik' keluar'.");

            //perulangan selama isi variabel inputuser tidak sama dengan "keluar"
            while (inputuser.ToLower() != "keluar")
            {
                Console.Write("\nketik sesuatu (atau 'keluar' untuk berhenti):");
                inputuser = Console.ReadLine(); //baca input dari user

                Console.WriteLine("anda mengetik: " + inputuser);
            }

                Console.WriteLine("\nprogram selesai. terima kasih!");
            }
        }
    }

