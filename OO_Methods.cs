public class Person(string firstName, string lastName, DateOnly birthday, string Pets = "None")
{
    public string First {get;} = firstName;
    public string Last {get;} = lastName;
    public DateOnly Birthday {get;} = birthday;
    public List<Pet> Pets {get;} = new();
    public abstract class Pet(string firstName)
    {
        public string First {get;} = firstName;
        public abstract string MakeNoise();
    }
    public class Cat(string firstName) : Pet(firstName)
    {
        public override string MakeNoise() => "Meow!";
        public override string ToString()
        {
            return $"{GetType().Name}, called {First}, which goes {MakeNoise()}";
        }
    }
    public class Dog(string firstName) : Pet(firstName)
    {
        public override string MakeNoise() => "Bark!";
        public override string ToString()
        {
            return $"{GetType().Name}, called {First}, which goes {MakeNoise()}";
        }
    }
    public static void SetPerson(string firstName, string lastName, DateOnly birthday)
    {
        var people1 = new Person(firstName, lastName, birthday);
        System.Console.WriteLine($"The name of the person is: {people1.First} {people1.Last}, and the Birthday: {people1.Birthday}.");
    }
    public static void SetPersonWithPets(string firstName, string lastName, DateOnly birthday, string pets)
    {
        var people1 = new Person(firstName, lastName, birthday, pets);
        if(pets == "Dog")
        {
            people1.Pets.Add(new Dog("Snoop"));
        }else if(pets == "Cat")
        {
            people1.Pets.Add(new Cat("Garfield"));
        }
        System.Console.WriteLine($"The name of the person is: {people1.First} {people1.Last}, the Birthday is: {people1.Birthday}, and the person has a {people1.Pets.Single()}.");
    }
}