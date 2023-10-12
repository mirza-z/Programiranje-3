using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSolarSystem
{
    public class SolarSystem
    {
        public string Name { get; set; }
        public List<Planet> Planets {  get; set; }  
        public bool HasAsteroidBelt { get; set; }
        public SolarSystem()
        {
            Planets = new List<Planet>();
        }
        public override string ToString()
        {
            string finalString = Name + "\n";
            for(int i = 0; i<Planets.Count; i++)
            {
                finalString += Planets[i] + "\n";
            }
            return finalString;
        }
    }
}
