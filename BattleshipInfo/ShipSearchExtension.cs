using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BattleshipInfo;

namespace BattleshipInfo
{
    public class ShipSearch
    {
        public string VesalNames { get; set; }
//        public List<string> Color { get; set; }
//        public string Country { get; set; }
        public string HowManyHits { get; set; }
        public int Page { get; set; }
        public int PageHowManyHits { get; set; }
    }

    public static class BirdSearchExtension
    {
        public static IEnumerable<Ships> Search(this IEnumerable<Ships> source, ShipSearch search)
        {
            return source.Where(s => search.VesalNames == null || s.VesalNames.Contains(search.VesalNames))
//                         .Where(s => search.Country == null || s.Habitats.Any(h => h.Country.Contains(search.Country)))
                         .Where(s => search.HowManyHits == null || s.HowManyHits == search.HowManyHits)
//                         .Where(s => search.Color.Any(c => c == s.PrimaryColor) ||
//                                     search.Color.Any(c => c == s.SecondaryColor) ||
//                                     search.Color.Join(s.TertiaryColors,
//                                                       sc => sc,
//                                                       tc => tc,
//                                                       (sc, tc) => (sc)).Any())
                         .Skip(search.Page * search.PageHowManyHits)
                         .Take(search.PageHowManyHits);
        }
    }
}
