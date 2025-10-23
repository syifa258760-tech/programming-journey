using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_m_syifa_maulana_xpplg2
{
    internal class Program
    {
        // method main adalah titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitunglagi; // variabel untuk menyimpan pilihan pengguna (y/n)

            //perulangan do-while akan menjalankan blok kode setidaknya satu kali
            //dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // membersihkan layar konson untuk setiap perhitungan baru
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                //  memanggil fungsi untuk menampilkan menu 
                tampilkanmenu();

                Console.Write("masukkan pilihan operasi ( 1-4): ");
                string pilihan = Console.ReadLine();

                // variabel untuk menampung angka dan hasil 
                double angka1, angka2, hasil = 0;

                // memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan inputt adalah angka yang valid
                if (ambilinputangka(out angka1, out angka2))
                {
                    // struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // pejumlahan
                            hasil = tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // pejumlahan
                            hasil = kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // pejumlahan
                            hasil = kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // pembagian
                            // penangganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nEror: tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            break;
                        default: // jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang anda masukkan tidak valid.");
                            break;
                    }
                }
                // menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\nApakah anda ingin menghitung kembali? (y/n): ");
                hitunglagi = Console.ReadLine();
                //.tolower () memebuat input menjadi huruf lecil, jadi 'Y' atau 'y' akan sama

            } while (hitunglagi.ToLower() == "y");

            // pesan penutup jika pengguna memilih untuk keluar
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini." +
                              "tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }
        // --- FUNGSI-FUNGSI BANTUAN ---

        // Fungsi untuk menampilkan menu pilihan
        static void tampilkanmenu()
        {
            Console.WriteLine("pilih operasi matematika:");
            Console.WriteLine("1. pemjumlahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");
        }
        //fungsi untuk mengambil input angka dari pengguna
        //menggunakan 'out' karena fungsi ini mengambilkan lebih dari satu nilai
        static bool ambilinputangka(out double angka1, out double angka2)
        {
            Console.Write("masukkan angka pertama:");
            //double.tryparse akan mencoba mengkonver string ke double.
            //jika berhasil, return true dan nilainya disimpan di variabel 'angka1'.
            //jika gagal,return false.
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("input untuk angka pertama tidak valid");
                angka2 = 0; // beri nilai default agar tidak eror
                return false;
            }

            Console.Write("masukkan angka kedua:");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("input untuk angka kedua tidak valid.");
                return false;
            }
            return true; // jika kedua input valid
        }
        // fungsi untuk operasi penjumlahan
        static double tambah(double a, double b)
        {
            return a + b;
        }

        // fungsi untuk operasi pengurangan
        static double kurang(double a, double b)
        {
            return a - b;
        }
        // fungsi untuk operasi perkalian
        static double kali(double a, double b)
        {
            return a * b;
        }

        //fungsi untuk operasi pembagian
        static double bagi(double a, double b)
        {
            return a / b;
        }





    }
}
