using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suhu_celcius_ke_fahrenheit_m_syifa_maulana_xpplg2
{
    internal class Program
    {
        /*buat fungsi konversuhu untuk mengubah suhu dari cercius ke Farenheit dengan
        rumus:
       F = (C x 9/5) + 32
       tampilkan hasil konversi pada program utama! */

        static double ConvertCelciusToFahrengeit(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("program conversi suhu dari celcius ke fahrenheit");
            Console.Write("masukkan suhu dalam celcius  = ");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ConvertCelciusToFahrengeit(celcius);
            Console.WriteLine($" {celcius} °C = {fahrenheit} °F");
        }
    }
}
