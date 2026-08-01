using System;

namespace Tugas1
{
    class BangunRuang
    {
        // Semua rumus menggunakan public int
        public int VolumeKubus(int sisi) { return sisi * sisi * sisi; }
        public int VolumeBalok(int panjang, int lebar, int tinggi) { return panjang * lebar * tinggi; }

        public int Mulai()
        {
            Console.Clear();
            Console.WriteLine("--- MENGHITUNG VOLUME BANGUN RUANG ---");
            Console.WriteLine("1. Kubus\n2. Balok");
            Console.Write("Pilih bangun ruang (1-2): ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;

            if (pilih == 1)
            {
                Console.Write("Masukkan panjang sisi: ");
                int sisi = Convert.ToInt32(Console.ReadLine());
                hasil = VolumeKubus(sisi);
                Console.WriteLine("Volume Kubus = " + hasil);
            }
            else if (pilih == 2)
            {
                Console.Write("Masukkan panjang: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan lebar: ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan tinggi: ");
                int t = Convert.ToInt32(Console.ReadLine());
                hasil = VolumeBalok(p, l, t);
                Console.WriteLine("Volume Balok = " + hasil);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
            Console.ReadLine();
            return 1;
        }
    }
}
