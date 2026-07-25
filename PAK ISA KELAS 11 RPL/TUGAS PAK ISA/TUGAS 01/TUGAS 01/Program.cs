using System;

namespace Tugas1
{
    class Program
    {
        // Tetap menggunakan static int, bukan static void
        static int Main(string[] args)
        {
            int pilihan = 0;

            while (pilihan != 5)
            {
                Console.Clear();
                Console.WriteLine("=== PROGRAM TUGAS 1 ===");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");

                int.TryParse(Console.ReadLine(), out pilihan);

                if (pilihan == 1)
                {
                    Kalkulator kal = new Kalkulator();
                    kal.Mulai();
                }
                else if (pilihan == 2)
                {
                    BangunDatar bd = new BangunDatar();
                    bd.Mulai();
                }
                else if (pilihan == 3)
                {
                    BangunRuang br = new BangunRuang();
                    br.Mulai();
                }
                else if (pilihan == 4)
                {
                    Zodiak zod = new Zodiak();
                    zod.Mulai();
                }
            }

            return 0; // Wajib mengembalikan nilai int karena tidak pakai void
        }
    }
}