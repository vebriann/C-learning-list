using System;
class kalkulator
{
    static void Main()
    {
        int bilangan1;
        int bilangan2;
        Console.WriteLine("Belajar Operator");

        Console.Write("Masukan BIlangan 1 = ");
        bilangan1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan BIlangan 2 = ");
        bilangan2 = int.Parse(Console.ReadLine());

        // operasi operator 

        var hasilTambah = bilangan1 + bilangan2;
        var hasilKurang = bilangan1 - bilangan2;
        var hasilBagi = bilangan1 / bilangan2;
        var hasilKali = bilangan1 * bilangan2;
        var hasilPangkat = Math.Pow(bilangan1,bilangan2);
        var sisaBagi = bilangan1 % bilangan2;
        var hasilAkar = Math.Sqrt(bilangan1);

        // output operator kalkulator

        Console.WriteLine("");
        Console.WriteLine("Belajar Operator Aritmatika");
        Console.WriteLine($"Hasil Penjumlahan       {bilangan1} + {bilangan2} = {hasilTambah}");
        Console.WriteLine($"Hasil Pengurangan       {bilangan1} - {bilangan2} = {hasilKurang}");
        Console.WriteLine($"Hasil Pembagian         {bilangan1} : {bilangan2} = {hasilBagi}");
        Console.WriteLine($"Hasil Perkalian         {bilangan1} x {bilangan2} = {hasilKali}");
        Console.WriteLine($"Hasil Perpangkatan      {bilangan1} ^ {bilangan2} = {hasilPangkat}");
        Console.WriteLine($"Hasil Sisa hasil bagi   {bilangan1} % {bilangan2} = {sisaBagi}");
        Console.WriteLine($"Hasil Akar dari {bilangan1} adalah {hasilAkar}");


        // operator perbandingan

        bool hasilA = bilangan1 > bilangan2;
        bool hasilB = bilangan1 < bilangan2;
        bool hasilC = bilangan1 <= bilangan2;
        bool hasilD = bilangan1 >= bilangan2;
        bool hasilE = bilangan1 != bilangan2;
        bool hasilF = bilangan1 == bilangan2;

        // output operator boolean

        Console.WriteLine("Belajar Operator Perbandingan");
        Console.WriteLine($"{bilangan1} > {bilangan2} = {hasilA}");
        Console.WriteLine($"{bilangan1} < {bilangan2} = {hasilB}");
        Console.WriteLine($"{bilangan1} <= {bilangan2} = {hasilC}");
        Console.WriteLine($"{bilangan1} >= {bilangan2} = {hasilD}");
        Console.WriteLine($"{bilangan1} != {bilangan2} = {hasilE}");
        Console.WriteLine($"{bilangan1} == {bilangan2} = {hasilF}");

    }
}