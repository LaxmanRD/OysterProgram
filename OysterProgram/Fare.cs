namespace OysterProgram
{
    public class Fare
    {
        const double ZONE_ONE_FARE = 2.50;
        const double ANY_ZONE_OUTSIDE_ZONE_ONE_FARE = 2.00;
        const double ANY_TWO_ZONES_INC_ZONE_ONE_FARE = 3.00;
        const double ANY_TWO_ZONES_EXC_ZONE_ONE_FARE = 2.25;
        const double THREE_ZONES_FAIR = 3.20;

        const double BUS_FARE = 1.80;
        const double MAX_TUBE_FARE = 3.20;

        public static double Bus
        {
            get { return BUS_FARE; }
        }

        public static double Tube
        {
            get { return MAX_TUBE_FARE; }
        }

        public static double Calculate_Final_Fare(string origin, string destination)
        {
            Zone_Finder objZoneFinder = new Zone_Finder(origin, destination);

            string zones = objZoneFinder.Travelled_Zones();

            if (zones.Contains("1"))
            {
                return ZONE_ONE_FARE;
            }
            else if (zones.Contains("2"))
            {
                return ANY_ZONE_OUTSIDE_ZONE_ONE_FARE;
            }
            else if (zones.Contains("different_zones"))
            {
                if (objZoneFinder.OriginZone.Contains("1") || objZoneFinder.DestinationZone.Contains("1"))
                {
                    return ANY_TWO_ZONES_INC_ZONE_ONE_FARE;
                }
                else
                {
                    return ANY_TWO_ZONES_EXC_ZONE_ONE_FARE;
                }
            }
            else
            {
                return THREE_ZONES_FAIR;
            }
        }
    }
}
