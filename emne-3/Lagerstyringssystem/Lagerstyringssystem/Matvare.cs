namespace Lagerstyringssystem
{
    internal class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Utløpsdato { get; set; }

        public Matvare(string navn, double pris, string utløpsdato)
        {
            Navn = navn;
            Pris = pris;
            Utløpsdato = utløpsdato;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn} Pris: {Pris}kr Utløpsdato: {Utløpsdato}");
        }
    }
}
