using System;
using System.Collections.Generic;
using System.Text;

namespace Planet_Mission
{

    abstract class PlanetMission
    { 
        public int MilesToPlanet;
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;

        public abstract void SetMissionInfo(int MilesToPlanet, int RocketFuelPerMile, long RocketSpeedMPH);

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }

        public string FuelNeeded()
        {
            return "Będziesz potrzebował " + UnitsOfFuelNeeded() + " jednostek paliwa, aby się tam dostać. Zajmie Ci to " + TimeNeeded() + " godzin.";

        }




    }
}
