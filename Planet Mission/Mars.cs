using System;
using System.Collections.Generic;
using System.Text;

namespace Planet_Mission
{
    class Mars : PlanetMission
    {
        public Mars()
        {
            SetMissionInfo(40000000, 100000, 25000);
        }

        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RocketFuelPerMile = rocketFuelPerMile;
            this.RocketSpeedMPH = rocketSpeedMPH;
        }

    }
}