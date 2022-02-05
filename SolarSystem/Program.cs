using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SolarSystem.Domain.Models;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            var celestialBodies = new List<CelestialBody>();

            #region celestialBodies
            celestialBodies.Add(new Star()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "0",
                HasSatelliteMoon = true,
                Mass = "1.989",
                Name = "Sun",
                OrbitalPeriod = "0",
                Picture = ""
            });
            celestialBodies.Add(new TerrestrialPlanet()
            {
                CanBeTerraformed = true,
                CanSustainLife = true, 
                DistanceFromSun = "149.6", 
                HasSatelliteMoon = true,
                Mass = "5.97",
                Name = "Earth",
                OrbitalPeriod = "365",
                Picture = ""
            });
            celestialBodies.Add(new TerrestrialPlanet()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "57.9",
                HasSatelliteMoon = false,
                Mass = "0.330",
                Name = "Mercury",
                OrbitalPeriod = "88",
                Picture = ""
            });
            celestialBodies.Add(new TerrestrialPlanet()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "108.2",
                HasSatelliteMoon = false,
                Mass = "4.87",
                Name = "Venus",
                OrbitalPeriod = "224",
                Picture = ""
            });
            celestialBodies.Add(new TerrestrialPlanet()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "0.384",
                HasSatelliteMoon = true,
                Mass = "0.642",
                Name = "Mars",
                OrbitalPeriod = "687",
                Picture = ""
            });
            celestialBodies.Add(new GasGiant()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "778.5",
                HasSatelliteMoon = true,
                Mass = "1898",
                Name = "Jupiter",
                OrbitalPeriod = "4331",
                Picture = ""
            });
            celestialBodies.Add(new GasGiant()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "1432.0",
                HasSatelliteMoon = true,
                Mass = "568",
                Name = "Saturn",
                OrbitalPeriod = "10747",
                Picture = ""
            });
            celestialBodies.Add(new IceGiant()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "2867.0",
                HasSatelliteMoon = true,
                Mass = "86.8",
                Name = "Uranus",
                OrbitalPeriod = "30589",
                Picture = ""
            });
            celestialBodies.Add(new IceGiant()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "4515.0",
                HasSatelliteMoon = false,
                Mass = "102",
                Name = "Neptune",
                OrbitalPeriod = "59800",
                Picture = ""
            });
            celestialBodies.Add(new DwarfPlanet()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "467",
                HasSatelliteMoon = false,
                Mass = "5972",
                Name = "Ceres",
                OrbitalPeriod = "149598",
                Picture = ""
            });
            celestialBodies.Add(new DwarfPlanet()
            {
                CanBeTerraformed = false,
                CanSustainLife = false,
                DistanceFromSun = "5906.4",
                HasSatelliteMoon = true,
                Mass = "0.0130",
                Name = "Pluto",
                OrbitalPeriod = "90560",
                Picture = ""
            });
            #endregion

            var solarSystem = new Domain.Models.SolarSystem(celestialBodies);
           Console.WriteLine(JsonConvert.SerializeObject(solarSystem.CelestialBodies.OrderBy(c => Convert.ToInt32(c.OrbitalPeriod))));
        }
    }
}
