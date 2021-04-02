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
            List<Ships> ships = new List<Ships>();

            // Add parts to the list.
            ships.Add(new Ships { VesalNames = "Carrier", HowManyHits = "5" });
            ships.Add(new Ships { VesalNames = "BattleShip", HowManyHits = "4" });
            ships.Add(new Ships { VesalNames = "Cruiser", HowManyHits = "3" });
            ships.Add(new Ships { VesalNames = "Submarine", HowManyHits = "3" });
            ships.Add(new Ships { VesalNames = "Distroyer", HowManyHits = "2" });

            // Write out the ships in the list. This will call the overridden ToString method
            // in the ships class.
            Console.WriteLine();
            foreach (Ships aPart in ships)
            {
                Console.WriteLine(HowManyHits);
            }





            var searchParameters = new BirdSearch
            {
                Size = "Medium",
                Country = "United States",
                Color = new List<string> { "White", "Brown", "Black" },
                Page = 0,
                PageSize = 5
            };
            Console.WriteLine("Type any key to begin search");
            var birds = BirdRepository.LoadBirds();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page}");
                birds.Search(searchParameters).ToList().ForEach(b =>
                {
                    Console.WriteLine($"Common Name: {b.CommonName}");
                });

                searchParameters.Page++;
            }
        }
    }
}