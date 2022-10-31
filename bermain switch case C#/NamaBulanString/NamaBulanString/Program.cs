using System;

class NamaBulanString
{
    static void Main()
    {
        string s, namaBulan;
        int noBulan= 0;
        Console.Clear();
        Console.Write("Masukan Nama Bulan: ");
        s = Console.ReadLine();
        namaBulan = s.ToLower();

        switch (namaBulan)
        {
            case "januhari": noBulan = 1; break;
            case "februari": noBulan = 2; break;
            case "maret": noBulan = 3; break;
            case "april": noBulan = 4; break;
            case "mei": noBulan = 5; break;
            case "juni": noBulan = 6; break;
            case "juli": noBulan = 7; break;
            case "agustus": noBulan = 8; break;
            case "september": noBulan = 9; break;
            case "oktober": noBulan = 10; break;
            case "november": noBulan = 11; break;
            case "desember": noBulan = 12; break;
            default:
                {
                    Console.WriteLine($"maaf tidak ada bulan {s} di kalender"); Environment.Exit(1); break;
                }
        }
        Console.WriteLine($"{s} adalah bulan ke-{noBulan}");

    }
}