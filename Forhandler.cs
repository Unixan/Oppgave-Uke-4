namespace Oppgave_Uke_4
{
    public class Forhandler
    {
        private string _name;
        private string _address;
        public List<Bil> Cars { get; }

        public Forhandler(string name, string address)
        {
            _name = name;
            _address = address;
            Cars = new List<Bil>();
        }

        public void AddCar(Bil bil)
        {
            Cars.Add(bil);
        }

        public void RemoveCar(string reg)
        {
            var carToRemove = Cars.SingleOrDefault(car => car.GetReg() == reg);
            Cars.Remove(carToRemove);
        }

        public Bil[] ListCarsOlderThan(int year)
        {
            var carList = Cars.Where(car => car.GetYear() < year).ToArray();
            return carList;
        }
        public Bil[] ListCarsWithDistanceMoreThan(int kms)
        {
            var carList = Cars.Where(car => car.GetDistance() > kms).ToArray();
            return carList;
        }
    }
}
