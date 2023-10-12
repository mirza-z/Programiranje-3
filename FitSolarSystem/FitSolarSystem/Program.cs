

using MiniSolarSystem;

namespace FitSolarSystem
{
   

    public class Program
    {
        public static void Main(string[] args)
        {
            // ********************************************************************************************************
            // Napraviti Solar System sastavljen od nekoliko dijelova:
            // CelestialObject: Name, Mass
            // Galaxy: Name, SolarSystem(array), Mass, Location
            // SolarSystem: Stars(array), Planets(array), HasAsteroidBelt(bool)
            // Planets: Name, Classification, Mass, Moons(array), IsHabitable(bool), HasWater(bool), HasRings(bool)
            // Moon: Name, Mass, IsHabitable, HasWater
            // ********************************************************************************************************
            Galaxy galaxy = new Galaxy();
            galaxy.Name = "MilkyWay";
            galaxy.Mass = float.MaxValue;
            galaxy.CelestiaoObjectLocation = new Location() { X =10, Y =20 };

            SolarSystem solarSystem = new SolarSystem();
            solarSystem.Name = "The fun solar system";
            solarSystem.HasAsteroidBelt = true;

            Planet planet = new Planet();
            planet.Name = "Earth";
            planet.Mass = 555;
            planet.IsHabitable = true;

            Moon moon = new Moon();
            moon.Name = "Mjesec";
            moon.Mass = 50;
            moon.IsHabitable = false;
            moon.HasWater = false;

            planet.Moons.Add(moon);

            Planet planet2 = new Planet();
            planet2.Name = "Saturn";
            planet2.Mass = 8818;
            planet2.IsHabitable = false;

            Moon moon1 = new Moon();
            moon1.Name = "Titan";
            moon1.Mass = 200;
            moon1.IsHabitable = true;
            moon1.HasWater = false;

            Moon moon2 = new Moon();
            moon2.Name = "Evropa";
            moon2.Mass = 150;
            moon2.IsHabitable = true;
            moon2.HasWater = true;

            planet2.Moons.Add(moon1);
            planet2.Moons.Add(moon2);

            solarSystem.Planets.Add(planet);
            solarSystem.Planets.Add(planet2);

            galaxy.SolarSystems.Add(solarSystem);

            Console.WriteLine(galaxy);

        }
    }

}