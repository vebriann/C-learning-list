using System;

class OperatorLogikaOR
{
    static void Main()
    {
        string nilaiHuruf;
        Console.WriteLine("Belajar Operator Logika OR");
        Console.Write("Masukan Nilai Huruf = ");
        nilaiHuruf = Console.ReadLine();

        if ((nilaiHuruf == "A") || (nilaiHuruf == "a"))
        {
            Console.WriteLine("Nilai Anda AMAT BAIK");
        }
        else if ((nilaiHuruf == "B") || (nilaiHuruf == "b"))
        {
            Console.WriteLine("Nilai Anda BAIK");
        }
        else if ((nilaiHuruf == "C") || (nilaiHuruf == "c"))
        {
            Console.WriteLine("Nilai Anda Cukup");
        }
        else if ((nilaiHuruf == "D") || (nilaiHuruf == "d"))
        {
            Console.WriteLine("Nilai Anda Kurang");
        }
        else if ((nilaiHuruf == "E") || (nilaiHuruf == "e"))
        {
            Console.WriteLine("Nilai Anda Sangat Kurang");
        }
        else
        {
            Console.WriteLine(" Kode Huruf Tidak Terdefinisi");
        }
    }
}