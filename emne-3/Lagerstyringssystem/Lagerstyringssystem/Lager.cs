namespace Lagerstyringssystem
{
    internal class Lager
    {
        private List<IProdukt> _products = new List<IProdukt>();
     
        public void ShowProducts()
        {
            var index = 1;
            foreach (var p in _products)
            {
                Console.Write($"{index++}. ");
                p.SkrivUtInfo();
            }
        }

        public void AddProduct(IProdukt produkt)
        {
            _products.Add(produkt);
        }

        public void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("Fjern et produkt");
            ShowProducts();
            Console.Write("Produkt number: ");
            var input = Convert.ToInt32(Console.ReadLine()) - 1;
            _products.RemoveAt(input);
        }

    }    
}
