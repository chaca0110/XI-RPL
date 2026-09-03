using System;
using System.Collections.Generic;

namespace BAB1_BAB3
{
    internal class bab12
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 12: ARRAY DAN KOLEKSI (Studi Kasus) ===");

            Console.WriteLine("1. Menyimpan nilai 10 siswa dalam array[cite: 1]:");
            int[] nilaiSiswa = { 80, 75, 90, 85, 95, 88, 72, 91, 78, 84 };
            Console.WriteLine("   Tersimpan 10 nilai dalam array.");

            int tertinggi = nilaiSiswa[0], totalKasus = 0;
            foreach (int n in nilaiSiswa)
            {
                if (n > tertinggi) tertinggi = n;
                totalKasus += n;
            }
            Console.WriteLine($"\n2. Menghitung nilai tertinggi dan rata-rata[cite: 1]:\n   Tertinggi: {tertinggi}\n   Rata-rata: {(double)totalKasus / nilaiSiswa.Length}");

            Console.WriteLine("\n3. Mengelola daftar nama menggunakan List<T>[cite: 1]:");
            List<string> daftarNama = new List<string> { "Jessica", "Rian" };
            daftarNama.Add("Citra");
            foreach (string nama in daftarNama)
            {
                Console.WriteLine($"   - {nama}");
            }

            Console.WriteLine("\n=== MINI PROJECT BAB 12 ===");
            int[] nilaiMini = { 75, 80, 90, 85, 70 };
            int totalMini = 0;
            foreach (int n in nilaiMini)
                totalMini += n;
            Console.WriteLine($"Rata-rata = {(double)totalMini / nilaiMini.Length}[cite: 1]");
        }
    }
}