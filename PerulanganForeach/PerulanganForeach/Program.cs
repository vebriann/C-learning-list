using System;
namespace Perulanganforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[5] { "Adi",
"Budi", "Caca", "Deni", "Lala" };
            Console.WriteLine("\n Nama yang anda masukan adalah: ");
        for (int a = 0; a < 5; a++)
            {
                Console.WriteLine(a + " " + nama[a] + " ");
            }
            Console.ReadLine();
        }
    }
}