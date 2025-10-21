using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. inisualisasi variabel penghitung(counter)
            int hitungan = 5;

            Console.WriteLine("memulai hitungan mundur");
            //2. perulangan'while'
            ///kondisi:  selama nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                //kode di dalam perulangan
                Console.WriteLine($"hitungan: {hitungan}");


                //3. update variabel penghitung (decrement/pengurangan)
                // ini penting agar perulangan tidak menjadi loop tak terbatas ( infiniti loop)
                hitungan = hitungan - 1;
                // atau bisa juga ditulis: hitungan--;
            }
            // Kode setelah perulangan selesai
            Console.WriteLine("selesai! hitungan mundur telah berakhir.");
            }
        }
    }

