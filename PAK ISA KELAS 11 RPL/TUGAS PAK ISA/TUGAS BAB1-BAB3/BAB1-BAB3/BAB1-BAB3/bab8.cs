using System;

namespace BAB1_BAB3
{
    internal class bab8
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 8: OPERATOR DALAM C# (Studi Kasus) ===");

            Console.WriteLine("1. Hitung total belanja tiga barang[cite: 1]:");
            double total = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"   Harga barang {i}: ");
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"   Total Belanja: {total}");

            Console.Write("\n2. Tentukan apakah siswa lulus berdasarkan nilai[cite: 1]\n   Masukkan nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   Status: " + (nilai >= 75 ? "Lulus" : "Tidak Lulus"));

            Console.Write("\n3. Hitung sisa pembagian menggunakan operator modulus[cite: 1]\n   Angka 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Angka 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"   Sisa bagi ({a} % {b}) = {a % b}");

            Console.WriteLine("\n=== MINI PROJECT BAB 8 ===");
            Console.Write("Harga Barang: ");
            double hargaBarang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Jumlah : ");
            int jumlahBarang = Convert.ToInt32(Console.ReadLine());
            double totalMini = hargaBarang * jumlahBarang;
            Console.WriteLine("Total = " + totalMini + "[cite: 1]");
        }
    }
}