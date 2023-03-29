namespace Oppgave_Uke_4
{
    public class Bil
    {
        public string Make { get; }
        public string Reg { get; }
        public int Year { get; }
        public int Kilometers { get; }

        public Bil(string make, string reg, int year, int kilometers)
        {
            Make = make;
            Reg = reg;
            Year = year;
            Kilometers = kilometers;
        }

        public string GetReg()
        {
            return Reg;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetDistance()
        {
            return Kilometers;
        }
    }
}
