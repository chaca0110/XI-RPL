using System;

namespace BAB1_BAB3
{
    class SiswaObj
    {
        public string Nama { get; set; }
        public int Nilai { get; set; }
    }

    class PersegiPanjangObj
    {
        public double P { get; set; }
        public double L { get; set; }
        public double Luas() => P * L;
    }

    class RekeningObj
    {
        private double saldo = 0;
        public void Setor(double jumlah) => saldo += jumlah;
        public double Saldo() => saldo;
    }

    // Class untuk Mini Project
    class Mobil
    {
        public string Merk { get; set; }
        public void Jalan()
        {
            Console.WriteLine($"{Merk} sedang berjalan.[cite: 1]");
        }
    }

    internal class bab14
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 14: OBJECT-ORIENTED PROGRAMMING (Studi Kasus) ===");

            SiswaObj s = new SiswaObj { Nama = "Rian", Nilai = 90 };
            Console.WriteLine($"1. Objek Siswa -> Nama: {s.Nama}, Nilai: {s.Nilai}[cite: 1]");

            PersegiPanjangObj pp = new PersegiPanjangObj { P = 8, L = 5 };
            Console.WriteLine($"2. Objek Persegi Panjang -> Luas: {pp.Luas()}[cite: 1]");

            RekeningObj rek = new RekeningObj();
            rek.Setor(500000);
            Console.WriteLine($"3. Objek Rekening -> Saldo: {rek.Saldo()}[cite: 1]");

            Console.WriteLine("\n=== MINI PROJECT BAB 14 ===");
            Mobil m = new Mobil();
            m.Merk = "Toyota";
            m.Jalan();
        }
    }
}