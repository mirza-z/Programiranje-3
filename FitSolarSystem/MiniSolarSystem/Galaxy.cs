namespace MiniSolarSystem
{
    public class Galaxy : CelestialObject
    {
        public List<SolarSystem> SolarSystems { get; set; }
        public Galaxy()
        {
            SolarSystems = new List<SolarSystem>();
        }
        public override string ToString()
        {
            string finalString = "";
            for(int i = 0; i<SolarSystems.Count; i++)
            {
                finalString += SolarSystems[i] + "\n";
            }
            return base.ToString() + "\n" + finalString;
        }
    }
}