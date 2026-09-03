using System;

namespace BAB1_BAB3
{
    internal class bab10
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 10: PERCABANGAN PADA C# (Studi Kasus) ===");

            Console.Write("1. Buat program menentukan bilangan ganjil atau genap[cite: 1]:\n   Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   " + (angka % 2 == 0 ? "Genap" : "Ganjil"));

            Console.Write("\n2. Buat program menghitung diskon berdasarkan total belanja[cite: 1]:\n   Total belanja: ");
            double belanja = Convert.ToDouble(Console.ReadLine());
            double diskon = (belanja >= 100000) ? belanja * 0.1 : 0;
            Console.WriteLine($"   Diskon: {diskon}\n   Bayar: {belanja - diskon}");

            Console.Write("\n3. Buat program menentukan kategori nilai siswa[cite: 1]:\n   Masukkan nilai: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 90) Console.WriteLine("   Kategori A");
            else if (n >= 80) Console.WriteLine("   Kategori B");
            else if (n >= 70) Console.WriteLine("   Kategori C");
            else Console.WriteLine("   Kategori D");

            Console.WriteLine("\n=== MINI PROJECT BAB 10 ===");
            Console.Write("Masukkan Umur: ");
            int umur = Convert.ToInt32(Console.ReadLine());
            if (umur >= 17)
                Console.WriteLine("Boleh membuat KTP[cite: 1]");
            else
                Console.WriteLine("Belum memenuhi syarat[cite: 1]");
        }
    }
}