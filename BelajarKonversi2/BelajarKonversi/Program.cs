using System;
using System.Transactions;

class BelajarKonversi
{
    static void Main()
    {

        double d = 123.456;
        //Konversi dari tipe double ke int
        int i = (int)d;
        Console.WriteLine("Nilai d" + d);
        Console.WriteLine("Nilai i " + i);

        object s;
        object a;
        object b;
        object l;
        object x;
        s = Convert.ToString(100);
        a = Convert.ToInt32(3.14);
        b = Convert.ToByte(1);
        l = Convert.ToInt64("1234556789");
        x = Convert.ToDateTime("2017-01-01");

        Console.WriteLine("Nilai a " + a + "\t Tipe a : " + a.GetType());
        Console.WriteLine("Nilai b " + b + "\t Tipe b : " + b.GetType());
        Console.WriteLine("Nilai l " + l + "\t Tipe l : " + l.GetType());          
        Console.WriteLine("Nilai x " + x + "\t Tipe x : " + x.GetType());

    }
}