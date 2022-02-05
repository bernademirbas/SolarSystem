namespace SolarSystem.Domain.Interfaces
{
    public interface ICelestialBody
    {
        public bool CanSustainLife { get; set; }

        public bool CanBeTerraformed { get; set; }

        public bool HasSatelliteMoon { get; set; }

    }
}
