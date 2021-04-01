using BattleshipInfo;
using System;
using System.Collections.Generic;

namespace BattleshipInfo
{
    public class ShipInfo : IEquatable<HowManyHits>
{
    public string VesalNames { get; set; }

    public int PartId { get; set; }
    public object HowManyHits { get; private set; }

    public override string ToString()
    {
        return "Ship: " + VesalNames + "   How Many Hits: " + HowManyHits;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        HowManyHits objAsHowManyHits = obj as HowManyHits;
        if (objAsHowManyHits == null) return false;
        else return ((IEquatable<HowManyHits>)this).Equals(objAsHowManyHits);
    }
    public override int GetHashCode()
    {
        return (int)HowManyHits;
    }
    bool IEquatable<HowManyHits>.Equals(HowManyHits other)
    {
        if (other == null) return false;
        return (this.HowManyHits.Equals(other.GetHowManyHits()));
    }
    // Should also override == and != operators.
}
    public class Example
{
    private static readonly bool HowManyHits;

    public static void Main()
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
    }
}
}