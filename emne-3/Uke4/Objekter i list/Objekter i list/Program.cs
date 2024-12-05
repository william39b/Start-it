namespace Objekter_i_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 25);
            Person person2 = new Person("Bob", 30);
            Person person3 = new Person("Charlie", 28);

            List<Person> list = new List<Person>
            {
                person1, person2 
            };

            list.Add(person3); // The Add Method adds new items to list
            list.Add(new Person("William", 23)); // Add anonymus Object to the list
            


            foreach (Person person in list)
            {
                Console.WriteLine(person.name);
            }

            Console.WriteLine(list.Count); // The Count propertiy gets the number of elements in a list
        }
    }

    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
