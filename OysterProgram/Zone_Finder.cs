using System.Collections.Generic;
using System.Linq;

namespace OysterProgram
{
    class Zone_Finder
    {
        public static Dictionary<string, string> StationZones = new Dictionary<string, string>
        {
            {"holborn", "1" },
            {"earls court", "1,2" },
            {"hammersmith", "2" },
            {"wimbledon", "3" },
        };

        string originZone = null;
        string destinationZone = null;

        public string OriginZone
        {
            get
            {
                return originZone;
            }
            set
            {
                originZone = value;
            }
        }

        public string DestinationZone
        {
            get
            {
                return destinationZone;
            }
            set
            {
                destinationZone = value;
            }
        }

        public Zone_Finder(string originStation, string destinationStation)
        {
            originZone = StationZones.Where(x => x.Key == originStation).FirstOrDefault().Value;
            destinationZone = StationZones.Where(x => x.Key == destinationStation).FirstOrDefault().Value;
        }

        public string Travelled_Zones()
        {
            string commonZone = Common.IntersecZones(originZone, destinationZone);

            string zones;

            if (commonZone.Trim().Length == 1)
            {
                zones = "one_zone_only " + commonZone;
            }
            else
            {
                zones = "different_zones";
            }

            return zones;
        }
    }
}