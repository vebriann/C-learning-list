using System;

public class VolumTabung
{
     public static void Main()
    {
        Console.WriteLine(" Masukan Jari Jari Tabung");
        Console.Write(" Jari Jari: ");
        int Jari = int.Parse(Console.ReadLine());
        Console.WriteLine(" Masukan Tinggi Tabung");
        Console.Write(" Tinggi: ");
        int Tinggi = int.Parse(Console.ReadLine());
        double phi = 3.14;
        var hasil = phi * Jari * Jari * Tinggi;
        Console.WriteLine($"Volume Tabung = {hasil}");

    }
}
