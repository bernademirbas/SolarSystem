using System.Collections.Generic;

namespace SolarSystem.Domain.Models
{
    public class SolarSystem
    {
        public SolarSystem(List<CelestialBody> celestialBodies)
        {
            CelestialBodies = celestialBodies;
        }
        public List<CelestialBody> CelestialBodies { get;}
    }
}
