using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {

            int ship = 7;

            string ans = "";

            int check = 0;

            Console.WriteLine("Välkommen till bootleg battleships");

            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ReadLine();

            Console.WriteLine("Skriv ett tal mellan 1-10");

            ans = Console.ReadLine();

            try
            {
                check = int.Parse(ans);
                while (ship != int.Parse(ans))
                {
                    Console.WriteLine("du missade");
                    ans = Console.ReadLine();
                }



                if (ship == int.Parse(ans))
                {
                    Console.WriteLine("Grattis du fick rätt");

                    Console.ReadLine();

                }
            }
            catch
            {
                Console.WriteLine("Du skrev inte ett nummer. nu stänger jag ner skiten >:(");
                Console.ReadLine();

            }


        }


    }
}

