using System;

namespace BAB1_BAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("      MENU TUGAS DASAR PEMROGRAMAN C# (BAB 1-14)  ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1.  Bab 1  : Pengenalan Pemrograman Komputer[cite: 1]");
                Console.WriteLine("2.  Bab 2  : Algoritma Dalam Pemrograman[cite: 1]");
                Console.WriteLine("3.  Bab 3  : Flowchart (Diagram Alir)[cite: 1]");
                Console.WriteLine("4.  Bab 4  : Pseudocode[cite: 1]");
                Console.WriteLine("5.  Bab 5  : Instalasi Visual Studio Dan .NET[cite: 1]");
                Console.WriteLine("6.  Bab 6  : Struktur Dasar Program C#[cite: 1]");
                Console.WriteLine("7.  Bab 7  : Variabel Dan Tipe Data C#[cite: 1]");
                Console.WriteLine("8.  Bab 8  : Operator Dalam C#[cite: 1]");
                Console.WriteLine("9.  Bab 9  : Input Dan Output Pada C#[cite: 1]");
                Console.WriteLine("10. Bab 10 : Percabangan (Selection) Pada C#[cite: 1]");
                Console.WriteLine("11. Bab 11 : Perulangan (Looping) Pada C#[cite: 1]");
                Console.WriteLine("12. Bab 12 : Array Dan Koleksi Dasar Pada C#[cite: 1]");
                Console.WriteLine("13. Bab 13 : Method (Fungsi) Pada C#[cite: 1]");
                Console.WriteLine("14. Bab 14 : Pengenalan Object-Oriented Programming (OOP) Pada C#[cite: 1]");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("0.  Keluar Aplikasi");
                Console.WriteLine("==================================================");
                Console.Write("Masukkan nomor pilihan bab (1-14): ");

                string pilihan = Console.ReadLine();

                Console.WriteLine("\n--------------------------------------------------");
                if (pilihan == "0")
                {
                    Console.WriteLine("Keluar dari program. Terima kasih!");
                    break;
                }
                else if (pilihan == "1") bab1.Jalankan();
                else if (pilihan == "2") bab2.Jalankan();
                else if (pilihan == "3") bab3.Jalankan();
                else if (pilihan == "4") bab4.Jalankan();
                else if (pilihan == "5") bab5.Jalankan();
                else if (pilihan == "6") bab6.Jalankan();
                else if (pilihan == "7") bab7.Jalankan();
                else if (pilihan == "8") bab8.Jalankan();
                else if (pilihan == "9") bab9.Jalankan();
                else if (pilihan == "10") bab10.Jalankan();
                else if (pilihan == "11") bab11.Jalankan();
                else if (pilihan == "12") bab12.Jalankan();
                else if (pilihan == "13") bab13.Jalankan();
                else if (pilihan == "14") bab14.Jalankan();
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan masukkan angka 1 sampai 14.");
                }

                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Tekan tombol ENTER untuk kembali ke menu utama...");
                Console.ReadLine();
            }
        }
    }
}