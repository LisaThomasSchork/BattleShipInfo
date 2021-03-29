using System.Collections.Generic;

public class ShipInfo : IEquatable<HowManyHits>
{
    public string VesalNames { get; set; }

    public int PartId { get; set; }

    public override string ToString()
    {
        return "Ship: " + VesalNames + "   How Many Hits: " + HowManyHits;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        HowManyHits objAsHowManyHits = obj as HowManyHits;
        if (objAsHowManyHits == null) return false;
        else return Equals(objAsHowManyHits);
    }
    public override int GetHashCode()
    {
        return HowManyHits;
    }
    public bool Equals(HowManyHits other)
    {
        if (other == null) return false;
        return (this.HowManyHits.Equals(other.HowManyHits));
    }
    // Should also override == and != operators.
}
public class Example
{
    public static void Main()
    {
        // Create a list of ships.
        List<Ship> ships = new List<Ship>();

        // Add parts to the list.
        ships.Add(new Ship() { VesalNames = "Carrier", HowManyHits = 5 });
        ships.Add(new Ship() { VesalNames = "BattleShip", HowManyHits = 4 });
        ships.Add(new Ship() { VesalNames = "Cruiser", HowManyHits = 3 });
        ships.Add(new Ship() { VesalNames = "Submarine", HowManyHits = 3 });
        ships.Add(new Ship() { VesalNames = "Distroyer", HowManyHits = 2 });

        // Write out the ships in the list. This will call the overridden ToString method
        // in the ships class.
        Console.WriteLine();
        foreach (Ship aPart in ships)
        {
            Console.WriteLine(HowManyHits);
        }
    }
}