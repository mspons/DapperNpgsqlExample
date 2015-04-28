using System;
using System.Configuration;

namespace DapperNpgsqlConsole
{
    class Program
    {
        static void Main()
        {
            using (var t = new DataRetriever(ConfigurationManager.ConnectionStrings["dapper"].ToString()))
            {
                Console.WriteLine("Beers{0}=====", Environment.NewLine);
                
                var beers = t.GetBeers();

                foreach (var beer in beers)
                {
                    Console.WriteLine("{0} - {1}", beer.Name, beer.Abv);
                }

                Console.WriteLine("{0}Styles{0}======", Environment.NewLine);

                var styles = t.GetStyles();

                foreach (var style in styles)
                {
                    Console.WriteLine("{0} - {1}", style.Name, style.Description);
                }
            }
        }
    }
}
