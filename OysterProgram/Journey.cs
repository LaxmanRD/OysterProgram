namespace OysterProgram
{
    public class Journey
    {
        string origin_point = null;
        string destination_point = null;

        TransportOptions _options = TransportOptions.Bus;

        public Journey(TransportOptions options, string start_point = null, string end_point = null)
        {
            _options = options;
            origin_point = start_point;
            destination_point = end_point;
        }

        public bool complete(string end_point)
        {
            destination_point = end_point;
            return true;
        }

        internal double Fare_Difference(string start_point, string end_point)
        {
            return Basic_Fare() - Final_Tube_Fare(start_point, end_point);
        }

        internal double Basic_Fare()
        {
            return (_options == TransportOptions.Bus) ? Fare.Bus : Fare.Tube;
        }

        internal double Final_Tube_Fare(string start_point, string end_point)
        {
            return Fare.Calculate_Final_Fare(start_point, end_point);
        }
    }
}
