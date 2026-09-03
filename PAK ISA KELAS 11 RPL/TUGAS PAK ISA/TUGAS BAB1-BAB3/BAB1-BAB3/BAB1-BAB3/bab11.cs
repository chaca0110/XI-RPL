using System;

namespace BAB1_BAB3
{
    internal class bab11
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 11: PERULANGAN (Studi Kasus) ===");

            Console.WriteLine("1. Menampilkan angka 1-100 (Disini ditampilkan 1-10)[cite: 1]:");
            for (int i = 1; i <= 10; i++) Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("\n2. Menjumlahkan bilangan 1-50[cite: 1]:");
            int total = 0;
            for (int i = 1; i <= 50; i++) total += i;
            Console.WriteLine($"   Hasil: {total}");

            Console.WriteLine("\n3. Membuat pola segitiga bintang[cite: 1]:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("   ");
                for (int j = 1; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine("\n=== MINI PROJECT BAB 11 ===");
            Console.Write("Masukkan jumlah siswa: ");
            int jumlahSiswa = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k <= jumlahSiswa; k++)
            {
                Console.Write($"Nama siswa ke-{k}: ");
                string namaSiswa = Console.ReadLine();
            }
            Console.WriteLine("Selesai menginput data[cite: 1].");
        }
    }
}