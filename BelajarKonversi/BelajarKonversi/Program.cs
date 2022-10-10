using System;

class BelajarKonversi
{
    static void Main(String[] args)
    {
        string nama;
        int umur;

        Console.WriteLine(" Masukan nama kamu ");
        Console.Write(" Nama: ");
        nama = Console.ReadLine();
        Console.WriteLine(" Masukan umur kamu ");
        Console.Write(" Umur: ");
        umur = int.Parse(Console.ReadLine());
        Console.WriteLine(" Masukan alamat kamu ");
        Console.Write(" alamat: ");
        var alamat = Console.ReadLine();
        Console.WriteLine($" Selamat datang {nama}");
        Console.WriteLine($" Umur Kamu adalah {umur}");
        Console.WriteLine($" alamat kamu ada di {alamat}");



    }
}