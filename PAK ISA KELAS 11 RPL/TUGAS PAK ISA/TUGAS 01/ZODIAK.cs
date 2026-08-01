using System;

namespace Tugas1
{
    class Zodiak
    {
        // Fungsi mengembalikan string, BUKAN void
        public string TentukanZodiak(int tgl, int bln)
        {
            if ((bln == 3 && tgl >= 21) || (bln == 4 && tgl <= 19)) return "Aries";
            if ((bln == 4 && tgl >= 20) || (bln == 5 && tgl <= 20)) return "Taurus";
            if ((bln == 5 && tgl >= 21) || (bln == 6 && tgl <= 20)) return "Gemini";
            if ((bln == 6 && tgl >= 21) || (bln == 7 && tgl <= 22)) return "Cancer";
            if ((bln == 7 && tgl >= 23) || (bln == 8 && tgl <= 22)) return "Leo";
            if ((bln == 8 && tgl >= 23) || (bln == 9 && tgl <= 22)) return "Virgo";
            if ((bln == 9 && tgl >= 23) || (bln == 10 && tgl <= 22)) return "Libra";
            if ((bln == 10 && tgl >= 23) || (bln == 11 && tgl <= 21)) return "Scorpio";
            if ((bln == 11 && tgl >= 22) || (bln == 12 && tgl <= 21)) return "Sagittarius";
            if ((bln == 12 && tgl >= 22) || (bln == 1 && tgl <= 19)) return "Capricorn";
            if ((bln == 1 && tgl >= 20) || (bln == 2 && tgl <= 18)) return "Aquarius";
            if ((bln == 2 && tgl >= 19) || (bln == 3 && tgl <= 20)) return "Pisces";

            return "Tanggal atau Bulan tidak valid";
        }

        public int Mulai()
        {
            Console.Clear();
            Console.WriteLine("--- CEK ZODIAK ---");
            Console.Write("Masukkan Tanggal Lahir (1-31): ");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Bulan Lahir (1-12): ");
            int bulan = Convert.ToInt32(Console.ReadLine());

            // Memanggil fungsi pengembali string
            string hasilZodiak = TentukanZodiak(tanggal, bulan);

            Console.WriteLine("\nZodiak kamu adalah: " + hasilZodiak);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
            Console.ReadLine();
            return 1;
        }
    }
}
