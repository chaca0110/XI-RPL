using System;

namespace BAB1_BAB3
{
    internal class bab13
    {
        static double LuasPersegiPanjang(double p, double l) => p * l;
        static double LuasLingkaran(double r) => 3.14 * r * r;
        static string CekGenapGanjil(int angka) => (angka % 2 == 0) ? "Genap" : "Ganjil";

        // Method untuk Mini Project
        static double HitungRata(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 13: METHOD / FUNGSI (Studi Kasus) ===");

            Console.WriteLine($"1. Membuat method menghitung luas persegi panjang (10x5)[cite: 1]: {LuasPersegiPanjang(10, 5)}");
            Console.WriteLine($"2. Membuat method menghitung luas lingkaran (r=7)[cite: 1]: {LuasLingkaran(7)}");
            Console.WriteLine($"3. Membuat method menentukan bilangan genap atau ganjil (14)[cite: 1]: {CekGenapGanjil(14)}");

            Console.WriteLine("\n=== MINI PROJECT BAB 13 ===");
            Console.WriteLine($"Hasil method HitungRata(80,90,85) adalah: {HitungRata(80, 90, 85)}[cite: 1]");
        }
    }
}