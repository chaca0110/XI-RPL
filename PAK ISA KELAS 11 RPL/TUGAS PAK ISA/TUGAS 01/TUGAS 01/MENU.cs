using System;

public class Menu
{
    public int TampilkanPilihan()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("       MENU UTAMA        ");
        Console.WriteLine("=========================");
        Console.WriteLine("1. Masuk ke Kalkulator");
        Console.WriteLine("2. Masuk ke Bangun Datar");
        Console.WriteLine("3. Masuk ke Bangun Ruang");
        Console.WriteLine("4. Masuk ke Zodiak");
        Console.WriteLine("=========================");
        Console.Write("Pilih menu (1-4): ");

        // Membaca input dari user dan mengkonversinya menjadi int
        int pilihan = Convert.ToInt32(Console.ReadLine());
        return pilihan;
    }
}
