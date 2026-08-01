using System;

namespace Tugas1
{
    class Kalkulator
    {
        // rumus perhitungan
        public int Tambah(int a, int b) { return a + b; }
        public int Kurang(int a, int b) { return a - b; }
        public int Kali(int a, int b) { return a * b; }
        public int Bagi(int a, int b) { return a / b; }

        public int Mulai()
        {
            Console.Clear();
            Console.WriteLine("--- KALKULATOR ---");
            Console.Write("Masukkan angka pertama: ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan operasi (+, -, *, /): ");
            string operasi = Console.ReadLine();

            Console.Write("Masukkan angka kedua: ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;

            if (operasi == "+") hasil = Tambah(angka1, angka2);
            else if (operasi == "-") hasil = Kurang(angka1, angka2);
            else if (operasi == "*") hasil = Kali(angka1, angka2);
            else if (operasi == "/")
            {
                if (angka2 == 0) Console.WriteLine("Tidak bisa membagi dengan 0!");
                else hasil = Bagi(angka1, angka2);
            }
            else Console.WriteLine("Operasi tidak valid!");

            Console.WriteLine("Hasil: " + hasil);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
            Console.ReadLine();

            return 1;
        }
    }
}