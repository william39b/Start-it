namespace ShowPlaces__OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Place place1 = new Place("Stavern", "Larvik", "Vestfold");
            Place place2 = new Place("Alta", "Alta", "Finnmark");
            Place place3 = new Place("Tromsø", "Tromsø", "Troms");

            place1.ShowPlace();
            place2.ShowPlace();
            place3.ShowPlace();
        }
    }
}
