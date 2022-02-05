# Solar System

This application is an ASP.NET 5 Console application that contains an inherited solar system class scheme. I thought of a "Solar System" base class that contains all celestial bodies. All celestial bodies ("stars", "terrestrial planets", "gas giants", "ice giants", and "dwarf planets") are inherited from "Celestial Body" abstract class. All celestial body items are objects of their special type (Exp: the Earth is a terrestrial planet). 


## Extendable & Improvable Parts Of The Project

• I assumed some relations regarding to real International Astronomical rules for solar system classes design. We can think and change implementations our business needs.

• I gets celestial bodies' data from "https://nssdc.gsfc.nasa.gov/planetary/factsheet/",
But could also use some public real data apis to get these data like : https://api.le-systeme-solaire.net/swagger/
.