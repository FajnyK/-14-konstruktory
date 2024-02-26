namespace _14_konstruktory
{
    public class Kot(string imie, int wiek)
    {
        public Kot(int wiek) : this("bella", wiek)
        {

        }
        public void PokazInformacje()
        {
            Console.WriteLine($"imie: {imie} \nwiek: {wiek}");
        }
    }
}
