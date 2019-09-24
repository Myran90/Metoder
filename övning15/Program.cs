using System;

namespace övning15
{
    class Program
    {
        static string HurPåDig(string hej, string mår)
        {
            string hurMårDu = hej+mår;
            return hurMårDu;
        }
        static void Main(string[] args)
        {
           string meddelande = HurPåDig("Hej på dig!", " Hur mår du?");
           Console.WriteLine(meddelande);
        }
    }
}
