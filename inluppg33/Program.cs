using System;
namespace inluppg33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tack för att du använder Kreb Bilar. hur många timmar skulle du vilja ha Krebbomobilen?");
            int timmar = int.Parse(Console.ReadLine());
            Console.WriteLine("mhm nice nice");
            int briz = timmar * 80;
            if (briz <950)
            {
                Console.WriteLine("ok det kommer kosta " + briz + "kr. betala helst inom 3.14 sekunder");
            }
            else
            {
                Console.WriteLine("din krebbomobil kommer kosta 950kr ok hejdå");
            }
        }
    
    }

}