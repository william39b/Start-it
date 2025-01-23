namespace Lagerstyringssystem
{
    internal class Main
    {
        private Lager _lager = new Lager();
        private List<IProdukt> _produkter;
        
        public Main()
        {
            _produkter = new List<IProdukt>
            {
                new Elektronikk("iPhone", 10000, 60),
                new Elektronikk("PS5", 7000, 12),
                new Matvare("Pizza", 70, "06.09.2025"),
                new Matvare("Pasta", 30, "01.01.2027"),
                new Klær("Genser", 400, "XL"),
                new Klær("T-sjorte", 200, "XL"),
            };

            SendProduktTilLager();
        }

        public void SendProduktTilLager()
        {
            foreach (var produkt in _produkter)
            {
                _lager.AddProduct(produkt);
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lagerstyringssystem \n");
                _lager.ShowProducts();

                Console.WriteLine("[1] Fjer et produkt fra listen");
                Console.WriteLine("[2] Lukk programmet");
                var input = Console.ReadLine();
                if (input == "1") _lager.RemoveProduct();
                if (input == "2") Environment.Exit(0);
            }
        }
    }
}
