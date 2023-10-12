using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MiniSolarSystem
{
    public class Planet : CelestialObject
    {
        public bool IsHabitable { get; set; }
        public List<Moon> Moons { get; set; }
        public Planet()
        {
            Moons = new List<Moon>();
        }
        public override string ToString()
        {
            string finalString = IsHabitable ? "Habitable\n" : "Not habitable\n";
            for (int i = 0; i < Moons.Count; i++)
            {
                finalString += Moons[i] + "\n";
            }
            return base.ToString() + "\n" + "Hability state: " + finalString;
        }
    }
}
