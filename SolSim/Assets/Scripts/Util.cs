using System;

namespace Util {
    public struct Constants {
        public static readonly int Parsec_InAu = 206265;
        public static readonly double Parsec_InKm = 3.086 * Math.Pow(10, 13);

        public static readonly double Au_InKm = 1.496 * Math.Pow(10, 8);

        public static readonly int EarthRadius_InKm = 6371;
    }

    public struct Tools {
        public static int SpeedUp = 365 * 24 * 60;
    }

    public struct InitialPositions {    // All in AU

    }

    public struct InitialVelocities {   // All in AU / year

    }

    public struct Mass {                // All in earth masses
        public static readonly int Sun = 333000;
    }
}
