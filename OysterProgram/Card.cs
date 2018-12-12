namespace OysterProgram
{
    public class Card
    {
        double _balance;
        Journey _objJourney;

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public Card()
        {
            _balance = 0;
            _objJourney = null;
        }

        public void TopUp(double amount)
        {
            AddMoney(amount);
        }

        public void TouchIn()
        {
            _objJourney = new Journey(TransportOptions.Bus, null, null);
            Charge(_objJourney.Basic_Fare());
        }

        public void TouchIn(TransportOptions options, string startingPoint)
        {
            _objJourney = new Journey(options, startingPoint.ToLower());
            Charge(_objJourney.Basic_Fare());
        }

        public void TouchOut(TransportOptions options, string startingPoint, string stoppingPoint)
        {
            if (_objJourney != null)
            {
                if (_objJourney.complete(stoppingPoint.ToLower()))
                {
                    RefundMoney(_objJourney.Fare_Difference(startingPoint.ToLower(), stoppingPoint.ToLower()));
                }
                else
                {
                    _objJourney = new Journey(options, startingPoint.ToLower(), stoppingPoint.ToLower());
                    Charge(_objJourney.Basic_Fare());
                }
            }
        }

        private void AddMoney(double amount)
        {
            _balance += amount;
        }

        private void RefundMoney(double amount)
        {
            _balance += amount;
        }

        private double Charge(double amount)
        {
            _balance -= amount;
            return _balance;
        }
    }
}
