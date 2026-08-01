using System;

namespace Tugas1
{
    class BangunDatar
    {
        //semua rumus menggunakan public int
        public int LuasPersegi(int sisi) { return sisi * sisi; }
        public int LuasPersegiPanjang(int panjang, int lebar) { return panjang * lebar; }
        public int LuasSegitiga(int alas, int tinggi) { return (alas * tinggi) / 2; }

        public int Mulai()
        {
            Console.Clear();
            Console.WriteLine("--- MENGHITUNG LUAS BANGUN DATAR ---");
            Console.WriteLine("1. Persegi\n2. Persegi Panjang\n3. Segitiga");
            Console.Write("Pilih bangun datar (1-3): ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;

            if (pilih == 1)
            {
                Console.Write("Masukkan panjang sisi: ");
                int sisi = Convert.ToInt32(Console.ReadLine());
                hasil = LuasPersegi(sisi);
                Console.WriteLine("Luas Persegi = " + hasil);
            }
            else if (pilih == 2)
            {
                Console.Write("Masukkan panjang: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan lebar: ");
                int l = Convert.ToInt32(Console.ReadLine());
                hasil = LuasPersegiPanjang(p, l);
                Console.WriteLine("Luas Persegi Panjang = " + hasil);
            }
            else if (pilih == 3)
            {
                Console.Write("Masukkan alas: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan tinggi: ");
                int t = Convert.ToInt32(Console.ReadLine());
                hasil = LuasSegitiga(a, t);
                Console.WriteLine("Luas Segitiga = " + hasil);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
            Console.ReadLine();
            return 1;
        }
    }
}