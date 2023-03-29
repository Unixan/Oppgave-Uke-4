namespace Oppgave_Uke_4
{
    internal class Program
    {
        static void Main()
        {
            var forhandler1 = new Forhandler("Bertils Brukte Biler", "Fjottveien 2");
            var bil1 = new Bil("Ferrari", "PH32145", 2022, 10000);
            var bil2 = new Bil("Lamborghini", "LH45367", 2020, 15000);
            var bil3 = new Bil("Volvo", "FU84756", 1980, 600000);
            forhandler1.AddCar(bil1);
            forhandler1.AddCar(bil2);
            forhandler1.AddCar(bil3);
            //forhandler1.RemoveCar("FU84756");
            //var oldCars = forhandler1.ListCarsOlderThan(2000);
            //var distanceHigherThan = forhandler1.ListCarsWithDistanceMoreThan(10000);
           

        }
    }
}