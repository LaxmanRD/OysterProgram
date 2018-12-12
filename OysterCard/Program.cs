using OysterProgram;
using System;

namespace OysterCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Card objCard = new Card();
            Console.WriteLine("Current balance ... " + objCard.Balance);
            Console.WriteLine("Topped oyster card with the amount £30");
            objCard.TopUp(30); // Top up Oyster card balance with £30
            Console.WriteLine("Current balance ... " + objCard.Balance);

            //Tube journey from Holborn to Earl’s Court
            objCard.TouchIn(TransportOptions.Tube, "Holborn");
            Console.WriteLine("--> Travelling by TUBE");
            Console.WriteLine("Touched in at Holborn (zone 1) \n Current balance ..." + objCard.Balance);

            objCard.TouchOut(TransportOptions.Tube, "Holborn", "earls court");
            Console.WriteLine("Touched out at Earl’s Court (zone 1/2) \n Current balance ..." + objCard.Balance);

            //BUS: 328 journey from Earl’s Court to Chelsea
            objCard.TouchIn(TransportOptions.Bus, "Earls Court");
            Console.WriteLine("--> Travelling by BUS");
            Console.WriteLine("Touched in at Earl’s Court (zone 1/2) \n Current balance ..." + objCard.Balance);

            //Tube journey from Earl’s court to Hammersmith
            objCard.TouchIn(TransportOptions.Tube, "Earls Court");
            Console.WriteLine("--> Travelling by TUBE");
            Console.WriteLine("Touched in at Earl’s Court (zone 1/2) \n Current balance ... " + objCard.Balance);

            objCard.TouchOut(TransportOptions.Tube, "Earls Court", "Hammersmith");
            Console.WriteLine("Touched out at Hammersmith (zone 2) \n Current balance ... " + objCard.Balance);

            //Final balance
            Console.WriteLine("Final card balance ... " + objCard.Balance);
            Console.ReadLine();
        }
    }
}
