using System;

class NamaHariString
{
    static void Main()
    {
        string s, namahari;
        int nohari = 0;
        Console.Clear();
        Console.Write("Masukan Nama Hari: ");
        s = Console.ReadLine();
        namahari = s.ToLower();

        switch(namahari)
        {
            case "senin": nohari = 1; break;
            case "selasa": nohari = 2; break;
            case "rabu": nohari = 3; break;
            case "kamis": nohari = 4; break;
            case "jumat": nohari = 5; break;
            case "sabtu": nohari = 6; break;
            case "ahad": nohari = 7; break;
            default:
                {
                    Console.WriteLine($"{s} Bukan nama hari"); Environment.Exit(1); break;
                }
        }
        Console.WriteLine($"{s} adalah hari ke-{nohari}"); 

    }
}