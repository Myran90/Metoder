using System;

namespace övning17
{
    class Program
    {
        static double Moms(double moms)
        {
            double addera = moms*1.25;
            return addera;
        }
        static void Main(string[] args)
        {
            double summa = Moms(100);
            Console.WriteLine(summa);
        }
    }
}
