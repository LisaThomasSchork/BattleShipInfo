using BattleshipInfo;
using System;
using System.Collections.Generic;

namespace BattleshipInfo
{
    public class ShipInfo : IEquatable<HowManyHits>
    {
        public string VesalNames { get; set; }
        public object HowManyHits { get; private set; }



        public ShipInfo(object howManyHits)
        {
            HowManyHits = howManyHits;
        }

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

    }
}
