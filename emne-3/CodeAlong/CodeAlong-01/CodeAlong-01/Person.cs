namespace CodeAlong_01;

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public List<string> Basket { get; private set; } 

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Basket = [];
    }

    public void PutBeerInBasket()
    {
        Basket = ["Beer", "Beer", "Beer", "Beer", "Beer", "Beer",];
    }

    public void RemoveBeerFromBasket()
    {
        Basket.Clear();
    }
}