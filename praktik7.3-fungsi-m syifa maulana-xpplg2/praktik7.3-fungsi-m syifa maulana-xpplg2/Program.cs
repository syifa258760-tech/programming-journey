﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik7._3_fungsi_m_syifa_maulana_xpplg2
{
    internal class Program
    {
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("masukkan angka pertama: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka kedua: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int hasil = tambah(x, y);
            Console.WriteLine("hasil penjumlahan: " + hasil);
        }
    }
}
