using System;

namespace övning21
{
    class Program
    {
        // Metorder som konverterar millimeter till cm, dec, meter och kilometer
        static double MmToCm(int metric)
        {
            double cm;
            cm = metric*0.1;
            return cm;
        }
        static double MmToDec(int metric)
        {
            double dec;
            dec = metric*0.01;
            return dec;
        }
        static double MmToMeter(int metric)
        {
            double meter;
            meter = metric*0.001;
            return meter;
        }
        static double MmToKm(int metric)
        {
            double km;
            km = metric*0.000001;
            return km;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            int metric;

            // En while-loop för att återkomma till menyn efter man har valt och utrfört sin konvertering
            while(true)
            {
            Console.WriteLine("======== Millimeter konverteraren =======");
            Console.WriteLine("================= Meny ==================");
            Console.WriteLine("[1] Centimeter");
            Console.WriteLine("[2] Decimeter");
            Console.WriteLine("[3] Meter");
            Console.WriteLine("[4] Kilometer");
            Console.WriteLine("=========================================");
            Console.Write("Ditt val: ");

            // En try/catch ifall man skulle skriva in bokstäver istället för siffror
            try
            {
            int val = Convert.ToInt32(Console.ReadLine());
            // En switch med 4 olika val och inuti valen har man anropen till dem olika metoderna ovan
            switch (val)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Mata in önskad längd i millimeter: ");
                    metric = Convert.ToInt32(Console.ReadLine());
                    double cm = MmToCm(metric);
                    Console.WriteLine(metric+" Milimeter blir: "+cm+" Centimeter!");
                    Console.WriteLine("=========================================");
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("Mata in önskad längd i millimeter: ");
                    metric = Convert.ToInt32(Console.ReadLine());
                    double dec = MmToDec(metric);
                    Console.WriteLine(metric+" Milimeter blir: "+dec+" Decimeter!");
                    Console.WriteLine("=========================================");
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("Mata in önskad längd i millimeter: ");
                    metric = Convert.ToInt32(Console.ReadLine());
                    double meter = MmToMeter(metric);
                    Console.WriteLine(metric+" Milimeter blir: "+meter+" Meter!");
                    Console.WriteLine("=========================================");
                    break;

                case 4:
                    Console.Clear();
                    Console.Write("Mata in önskad längd i millimeter: ");
                    metric = Convert.ToInt32(Console.ReadLine());
                    double km = MmToKm(metric);
                    Console.WriteLine(metric+" Milimeter blir: "+km+" Kilometer!");
                    Console.WriteLine("=========================================");
                    break;
            }
            }
            // Felmeddelandet för try/catch, låter användaren veta vad som kan ha gått fel
            catch
            {
                Console.WriteLine("Du får bara använda dig utav 1-4 när du väljer i menyn...");
                Console.WriteLine("Du får bara skriva in siffror i dem olika menyerna...");
                Console.WriteLine("Prova igen...");
                return;
            }
            }
        }
    }
}
