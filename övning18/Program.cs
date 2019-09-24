using System;

namespace övning18
{
    class Program
    {
        static double Moms(double produktKostnad, double moms)
        {
            double medMoms = produktKostnad*moms;
            return medMoms;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vad kostar produkten? ");
            double värde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hur mycket moms? ");
            double moms = Convert.ToDouble(Console.ReadLine());
            double värdeMoms = Moms(värde, moms);
            System.Console.Write("Din produkt inkl moms kostar: "+värdeMoms);

        }
    }
}
