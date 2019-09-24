using System;

namespace övning20
{
    class Program
    {
        static bool Myndig(int myndig)
        {
            if(myndig>=18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = Convert.ToInt32(Console.ReadLine());
            
            bool omMyndig = Myndig(ålder);
            if(omMyndig == true)
            {
                Console.WriteLine("Du är myndig");
            }

            else
            {
                Console.WriteLine("Du är inte myndig");
            }
        }
    }
}
