
namespace MiniSolarSystem
{
    public class CelestialObject
    {
        public string Name { get; set; }
        public float Mass { get; set; }
        public int MyProperty { get; set; }
        public Location CelestiaoObjectLocation{ get; set; }
        public override string ToString()
        {
            return $"Name: {Name} \n Mass: {Mass} \n Location: {CelestiaoObjectLocation}";
        }
    }
}
