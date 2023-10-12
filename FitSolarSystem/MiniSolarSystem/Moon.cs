using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSolarSystem
{
    public class Moon :CelestialObject
    {
        public bool IsHabitable { get; set; }
        public bool HasWater { get; set; }

        public override string ToString()
        {
            string finalString = IsHabitable ? "Habitable" : "Not habitable";
            finalString += HasWater ? " and has water" : " and has no water";
            return base.ToString() + "\n" + "Hability and water state: " + finalString;
        }
    }
}
