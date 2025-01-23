namespace Lagerstyringssystem
{
    internal class Elektronikk : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Garantitid { get; set; }

        public Elektronikk(string navn, double pris, int garantiTid)
        {
            Navn = navn;
            Pris = pris;
            Garantitid = garantiTid;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn} Pris: {Pris}kr Garantitid: {Garantitid}md.");
        }
    }
}
