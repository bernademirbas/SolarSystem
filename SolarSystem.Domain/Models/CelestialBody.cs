using SolarSystem.Domain.Interfaces;

namespace SolarSystem.Domain.Models
{
    public abstract class CelestialBody : ICelestialBody
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string DistanceFromSun { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Mass { get; set; }
        public bool CanSustainLife { get; set; }
        public bool CanBeTerraformed { get; set; }
        public bool HasSatelliteMoon { get; set; }
    }
}
