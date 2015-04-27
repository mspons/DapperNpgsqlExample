using System;

namespace DapperNpgsqlConsole
{
    class Program
    {
        static void Main()
        {
            using (var t = new DataRetriever())
            {
                Console.WriteLine("Beers\n=====");
                
                var beers = t.GetBeers();

                foreach (var beer in beers)
                {
                    Console.WriteLine("{0} - {1}", beer.Name, beer.Abv);
                }

                Console.WriteLine("\nStyles\n======");

                var styles = t.GetStyles();

                foreach (var style in styles)
                {
                    Console.WriteLine("{0} - {1}", style.Name, style.Description);
                }
            }
        }
    }
}
