namespace CodeAlong_01;

public class Shop
{
    private Person _person;
    
    public Shop(Person person) 
    {
        _person = person;
    }

    public void BuyBeer()
    {
        _person.PutBeerInBasket();
        CustomerAppearance();
        CheckId();
    }

    private void CustomerAppearance()
    {
        if (_person.Age >= 25)
        {
            Console.Write($"{_person.Name} Looks old. ");
        }
    }

    private void CheckId()
    {
        switch (_person.Age)
        {
            case >= 18 and <= 25:
                Console.Write($"{_person.Name} is over 18. ");
                break;
            case <= 18:
                Console.Write($"{_person.Name} is underage. ");
                _person.RemoveBeerFromBasket();
                break;
        }
        Console.WriteLine($"And left the store with {_person.Basket.Count} beers");
    }
}