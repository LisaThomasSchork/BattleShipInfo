using BattleshipInfo;
using System;
using System.Collections.Generic;

namespace BattleshipInfo
{
    public class ShipInfo : IEquatable<HowManyHits>
    {
        public string VesalNames { get; set; }
        public object HowManyHits { get; private set; }
        public object HowManyMisses { get; private set; }



        public ShipInfo(object howManyMisses, object howManyHits)
        {
            HowManyMisses = howManyMisses;
            HowManyHits = howManyHits;
        }

        public override string ToString()
        {
            return "Ship: " + VesalNames + "   How Many Hits: " + HowManyHits;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            HowManyHits objAsHowManyMisses = obj as HowManyHits;
            if (objAsHowManyMisses == null) return false;
            else return ((IEquatable<HowManyHits>)this).Equals(objAsHowManyMisses);
        }

        public override int GetHashCode()
        {
            return (int)HowManyHits;
        }

        bool IEquatable<HowManyHits>.Equals(HowManyHits other)
        {
            if (other == null) return false;
            return this.HowManyHits.Equals(other.HowManyMisses());
        }

        internal static object HowManyHits()
        {
            throw new NotImplementedException();
        }


        // Should also override == and != operators.



    }
}
