// 

using System;

class PercabanganC
{
    static void Main(String[] args)

    {
        string pilih;
        int angka1;
        int angka2;
        int hasil;

        Console.WriteLine(" Pilih aritmatika operation ");
        Console.WriteLine(" 1. Penambahan ");
        Console.WriteLine(" 2. Pengurangan ");
        Console.WriteLine(" 3. Perkalian ");
        Console.WriteLine(" 4. Pembagian ");
        Console.WriteLine("");
        Console.Write(" pilih: ");
        pilih = Console.ReadLine();
        if (pilih == "1")
        {
            Console.WriteLine("");
            Console.WriteLine(" Masukan Nilai Pertama");
            Console.Write(" Nilai: ");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Masukan Nilai kedua");
            Console.Write(" Nilai: ");
            angka2 = int.Parse(Console.ReadLine());

            hasil = angka1 + angka2;

            Console.WriteLine("");
            Console.WriteLine($" Hasil Dari Nilai {angka1} dan {angka2} adalah {hasil}");

        }
        else if (pilih == "2") 
        {
            Console.WriteLine("");
            Console.WriteLine(" Masukan Nilai Pertama");
            Console.Write(" Nilai: ");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Masukan Nilai kedua");
            Console.Write(" Nilai: ");
            angka2 = int.Parse(Console.ReadLine());

            hasil = angka1 - angka2;

            Console.WriteLine("");
            Console.WriteLine($" Hasil Dari Nilai {angka1} dan {angka2} adalah {hasil}");
        }
        else if (pilih == "3")
        {
            Console.WriteLine("");
            Console.WriteLine(" Masukan Nilai Pertama");
            Console.Write(" Nilai: ");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Masukan Nilai kedua");
            Console.Write(" Nilai: ");
            angka2 = int.Parse(Console.ReadLine());

            hasil = angka1 * angka2;

            Console.WriteLine("");
            Console.WriteLine($" Hasil Dari Nilai {angka1} dan {angka2} adalah {hasil}");
        }
        else if (pilih == "4")
        {
            Console.WriteLine("");
            Console.WriteLine(" Masukan Nilai Pertama");
            Console.Write(" Nilai: ");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Masukan Nilai kedua");
            Console.Write(" Nilai: ");
            angka2 = int.Parse(Console.ReadLine());

            hasil = angka1 / angka2;

            Console.WriteLine("");
            Console.WriteLine($" Hasil Dari Nilai {angka1} dan {angka2} adalah {hasil}");

        }

        else
        {
            Console.WriteLine(" maaf pilihan yang anda pilih tidak ada!");
        }
    }
}