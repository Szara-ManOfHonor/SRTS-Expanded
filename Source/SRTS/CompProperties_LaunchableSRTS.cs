﻿using Verse;

namespace SRTS
{
    public class CompProperties_LaunchableSRTS : CompProperties
    {
        public CompProperties_LaunchableSRTS()
        {
            this.compClass = typeof (CompLaunchableSRTS);
        }

        public float travelSpeed = 25f;
        public int minPassengers = 1;
        public int maxPassengers = 2;
    }
}
