using System;

namespace övning16
{
    class Program
    {
        static int Addera(int tal1, int tal2)
        {
            int addera = tal1+tal2;
            return addera;
        }
        static void Main(string[] args)
        {
            int summa = Addera(5, 1);
            Console.WriteLine(summa);
        }
    }
}
