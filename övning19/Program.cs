using System;

namespace övning19
{
    class Program
    {
        static double ToPercentage(double decimalTal)
        {
            decimalTal = Convert.ToInt32(decimalTal);
            return decimalTal;
        }
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett decimaltal: ");
            double decimalTal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ditt decimaltal avrundat blir: "+ToPercentage(decimalTal));            
        }
    }
}
