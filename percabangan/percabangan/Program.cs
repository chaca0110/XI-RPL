// Materi Percabangan

// Pada kesempatan kali ini kita akan mempelajari percabangan: If, Else, Else IF, dan Switch


// Percabangan digunakan untuk mengambil keputusan pada program
// Program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF
int umur = 18;

if (umur >= 17) // If digunakan untuk mengecek kondisi,
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
}



// ELSE

if (umur >= 17) // If digunakan untuk mengecek kondisi,
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
}
else // Else dijalankan jika kondisi False
     // Else digunakan sebagai alternatif ketika kondisi if tidak terpenuhi
{
    Console.WriteLine("Belum Boleh membuat KTP");
}

// ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");

}
else if (nilai >= 75) // Else If digunakan untuk menambahkan kondisi lain
                      // Else If memungkinkan program memeriksa beberapa kondisi Berbeda
{
    Console.WriteLine("Grade B");

}
else
{
    Console.WriteLine("Grade C");

}


// Switch

// Digunakan untuk memilih kondisi berdasarkan nilai tertentu

string hari = "Senin";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari Pertama");
        break;

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default:
        Console.WriteLine("Hari Lain");
        break;
}
