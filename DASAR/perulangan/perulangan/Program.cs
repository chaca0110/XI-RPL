// Materi Perulangan For, While, dan Foreach

// Perulangan digunakan untuk menjalankan perintah berulang Otomatis.
// Dengan Perulangan, program dapat menghemat penulisan Code



// FOR
// Digunakan ketika jumlah perulangan sudah diketahui

// For digunakan untuk perulangan dengan jumlah tertentu

// Isi (Parameter) dari For loop
// int i = 1    <- Nilai awal perulangan
// i <= 5       <- Kondisi selama perulangan berjalan
// i++          <- Menambahkan nilai i setiap perulangan


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan Ke - " + i);
}



// 2. While Loop
// digunakan ketika jumlah perulangan belum diketahui secara pasti

int angka = 1;

while (angka <= 5) // While akan berjalan selama kondisi bernilai true
{
    Console.WriteLine("Angka: " + angka);

    angka++; // Increment wajib, agar perulangan tidak berjalan terus menerus
             // Jika increment tidak ditambahkan, program dapat mengalami infinite loop
}

// nilai variabel Angka akan tetap 1 sedangkan Write line tetap terus berjalan


// 3. Foreach Loop
// Digunakan untuk mengambil data dari kumpulan data seperti array atau list

// Foreach membaca data satu per satu dari array

string[] namaBuah = { "Apel", "Pisang", "Mangga" };

foreach (string buah in namaBuah) // variabel buah pada parameter foreach akan berisi data dari array namaBuah
{
    Console.WriteLine(buah);
}

// Coba kita Run


// Dengan ini kita sudah mempelajari pengulangan menggunakan For loop, While Loop, serta Foreach Loop