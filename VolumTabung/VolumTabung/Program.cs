using System;

public class VolumTabung
{
<<<<<<< HEAD
    public static void Main()
=======
     public static void Main()
>>>>>>> c8b4b747bcd807ee0025d6fc576b50210d5b8c16
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
