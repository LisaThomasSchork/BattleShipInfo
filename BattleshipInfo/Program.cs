using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Create a list of ships.
            List<Ships> ships = new List<Ships>
            {

                // Add parts to the list.
                new Ships { VesalNames = "Carrier", HowManyHits = "5" },
                new Ships { VesalNames = "BattleShip", HowManyHits = "4" },
                new Ships { VesalNames = "Cruiser", HowManyHits = "3" },
                new Ships { VesalNames = "Submarine", HowManyHits = "3" },
                new Ships { VesalNames = "Distroyer", HowManyHits = "2" }
            };

            // Write out the ships in the list. This will call the overridden ToString method
            // in the ships class.
            Console.WriteLine();

            var searchParameters = GetSearchParameters();
            Console.WriteLine("Type any key to begin search");
            var Ships = ShipInfo.();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page}");
                Ships.Search(searchParameters).ToList().ForEach(b =>
                {
                    Console.WriteLine($"Vesal Name: {b.VesalNames}");
                });

                searchParameters.Page++;
            }
        }

        private static ShipSearch GetSearchParameters()
        {
            return new ShipSearch
            {
                VesalNames = "Ships Name",
                HowManyHits = "How Many Hits",
                Page = 0,
            };
        }
    }
}